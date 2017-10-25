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
            docText = System.IO.File.ReadAllText(docPath);

            UploadedDocumentClass.SetUploadedDocument(docName, docPath, docText);
            
            documentTitle.Text = UploadedDocumentClass.SetFileName();
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
            optionsGroupBox.Visible = true;
        }

        /// <summary>
        /// Skriva meni od korisnika
        /// </summary>
        private void HideOptions()
        {
            optionsGroupBox.Visible = false;
        }

        //private void signDocumentButton_Click(object sender, EventArgs e)
        //{
        //    cryptographyRSAClass getRSAKeys = new cryptographyRSAClass();
        //    string keys = getRSAKeys.getKeys();
        //}

        /// <summary>
        /// Metoda koja se poziva na klik tipke za SHA1 sažimanje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shaDigestButton_Click(object sender, EventArgs e)
        {
            string docContent = UploadedDocumentClass.GetFileContent();
            SHADigestClass shaObject = new SHADigestClass(docContent);

            string calculatedDigest = "";
            calculatedDigest =  shaObject.GetDigest();

            bool saved = shaObject.SaveDigestInTxt(calculatedDigest);

            if (saved)
                MessageBox.Show("Digest created!");
            else
                MessageBox.Show("ERROR!!!");
        }

        private void encryptAESButton_Click(object sender, EventArgs e)
        {

        }
    }
}
