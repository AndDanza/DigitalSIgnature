using DigitalSignature.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature.Forms
{
    public partial class UploadDocumentForm : Form
    {
        public UploadDocumentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja se izvršava kad korisnik ispusti datoteku iznad panela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dragDropInput_DragDrop(object sender, DragEventArgs e)
        {
            GetDocumentData(e);
            ShowDocumentMetadata();
            ShowOptions();
        }

        /// <summary>
        /// Poziva se kad korisnik koji je sa datotekom ušao u granice panela izađe iz istog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dragDropInput_DragLeave(object sender, EventArgs e)
        {
            dragDropInput.BackColor = SystemColors.Control;
        }

        /// <summary>
        /// Poziva se kad korisnik sa datotekom uđe u granice panela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dragDropInput_DragEnter(object sender, DragEventArgs e)
        {
            dragDropInput.BackColor = Color.LightGreen;
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// Metoda koja se poziva kad korisnik klikne na crni x na ekranu kako bi uklonio datoteku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            HideDocumentMetadata();
            HideOptions();
        }

        /// <summary>
        /// Dohvaća podatke o datoteci koju je korisnik DragnDrop-ao
        /// </summary>
        /// <param name="e"></param>
        private void GetDocumentData(DragEventArgs e)
        {
            string docPath = "";
            string docName = "";
            string docText = "";

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            docPath = files[0].ToString();
            docName = docPath.Substring(docPath.LastIndexOf('\\') + 1);
            docText = File.ReadAllText(docPath);

            UploadedDocumentClass.SetUploadedDocument(docName, docPath, docText);
            
            documentTitle.Text = UploadedDocumentClass.GetFileName();
            documentPath.Text = UploadedDocumentClass.GetFilePath();
            documentContentTextBox.Text = UploadedDocumentClass.GetFileContent();
        }

        /// <summary>
        /// Metoda koja skriva sve metode inputa sa forme
        /// </summary>
        private void HideDocumentMetadata()
        {
            //Vrati sve na zadane posavke izgleda
            dragDropInput.BackColor = SystemColors.Control;
            dragDropLabel.Show();
            dragDropInput.BorderStyle = BorderStyle.None;
            dragDropInput.AllowDrop = true;

            //Sakrij podatke o učitanoj datoteci
            uplodedDocument.Visible = false;

            //Sakrij tipku za uklanjanje datoteke
            removeButton.Visible = false;

            //sakrij sadržaj datoteke
            documentContentLable.Visible = false;
            documentContentTextBox.Visible = false;
            UploadedDocumentClass.CleanData();
            documentContentTextBox.Clear();
        }

        /// <summary>
        /// Metoda koja korisniku prikazuje sve metode inputa na formi
        /// </summary>
        private void ShowDocumentMetadata()
        {
            //Ukloni natpis i istakni panel
            dragDropLabel.Hide();
            dragDropInput.AllowDrop = false;
            dragDropInput.BackColor = SystemColors.ControlLight;
            dragDropInput.BorderStyle = BorderStyle.Fixed3D;

            //Prkaži podatke o datoteci
            uplodedDocument.Visible = true;

            //Prikaži tipku za uklanjanje datoteke
            removeButton.Visible = true;

            //prikaži sadržaj datoteke
            documentContentLable.Visible = true;
            documentContentTextBox.Visible = true;
        }

        /// <summary>
        /// Prikazuje meni korisniku
        /// </summary>
        private void ShowOptions()
        {
            panelOptions.Enabled = true;
        }

        /// <summary>
        /// Skriva meni od korisnika
        /// </summary>
        private void HideOptions()
        {
            panelOptions.Enabled = false;
        }

        /// <summary>
        /// Metoda koja se poziva na klik tipke za SHA1 sažimanje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionSHA1Digest_Click(object sender, EventArgs e)
        {
            string docContent = UploadedDocumentClass.GetFileContent();
            SHADigestClass shaObject = new SHADigestClass(docContent);

            string calculatedDigest = "";
            shaObject.GetDigest();
            calculatedDigest = shaObject.GetStringDigest();

            SaveToTxt("helpfile_sha1_digest", calculatedDigest);

            LoadingScreenForm loadScreen = new LoadingScreenForm(UploadedDocumentClass.GetFileName(), "SHA1 Digest");
            loadScreen.ShowDialog();
        }

        private void optionEncryptAES_Click(object sender, EventArgs e)
        {
            SymmetricCryptography encrypterAES = new SymmetricCryptography(false);
            string contentToEncrypt = UploadedDocumentClass.GetFileContent();
            string encrypted = encrypterAES.EncryptDocumentAES(contentToEncrypt);
            
            LoadingScreenForm loadScreen = new LoadingScreenForm(UploadedDocumentClass.GetFileName(), "AES Encryption");
            loadScreen.ShowDialog();

            SaveToTxt("helpfile_aes_encrypted", encrypted);
        }

        private void optionDecryptAES_Click(object sender, EventArgs e)
        {
            SymmetricCryptography decrypterAES = new SymmetricCryptography(true);
            string contentToDecrypt = UploadedDocumentClass.GetFileContent();
            string decrypted = decrypterAES.DecryptDocumentAES(contentToDecrypt);

            LoadingScreenForm loadScreen = new LoadingScreenForm(UploadedDocumentClass.GetFileName(), "AES Decryption");
            loadScreen.ShowDialog();

            SaveToTxt("helpfile_aes_decrypted", decrypted);
        }

        private void optionEncryptRSA_Click(object sender, EventArgs e)
        {
            AsymmetricCryptography encrypterRSA = new AsymmetricCryptography();
            encrypterRSA.GenerateKeys();
            string contentToEncrypt = UploadedDocumentClass.GetFileContent();

            string encrypted = encrypterRSA.EncryptDocumentRSA(contentToEncrypt);

            LoadingScreenForm loadScreen = new LoadingScreenForm(UploadedDocumentClass.GetFileName(), "RSA Encryption");
            loadScreen.ShowDialog();

            SaveToTxt("helpfile_rsa_encrypted", encrypted);
        }

        private void optionDecryptRSA_Click(object sender, EventArgs e)
        {
            AsymmetricCryptography decrypterRSA = new AsymmetricCryptography();
            string contentToDecrypt = UploadedDocumentClass.GetFileContent();

            string decrypted = decrypterRSA.DecryptDocumentRSA(contentToDecrypt);

            LoadingScreenForm loadScreen = new LoadingScreenForm(UploadedDocumentClass.GetFileName(), "RSA Decryption");
            loadScreen.ShowDialog();

            SaveToTxt("helpfile_rsa_decrypted", decrypted);
        }

        /// <summary>
        /// Metoda za pohranu sadržaja u datoteku
        /// </summary>
        /// <param name="title">Naslov datoteke</param>
        /// <param name="content">Sadržaj datoteke</param>
        private void SaveToTxt(string title, string content)
        {
            using (StreamWriter file = new StreamWriter(@".\" + title + ".txt"))
            {
                file.Write(content);
            }
        }

        private void optionSignDocument_Click(object sender, EventArgs e)
        {
            string toSign = UploadedDocumentClass.GetFileContent();

            DigitalSignatureClass signObject = new DigitalSignatureClass();
            string signedDocument = signObject.SignDocument(toSign);

            SaveToTxt("helpfile_signature", signedDocument+"\r\n"+toSign);
        }
    }
}
