﻿using DigitalSignature.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void dragDropInput_DragDrop(object sender, DragEventArgs e)
        {
            GetDocumentData(e);
            ShowDocumentMetadata();
            ShowOptions();
        }

        private void dragDropInput_DragLeave(object sender, EventArgs e)
        {
            dragDropInput.BackColor = SystemColors.Control;
        }

        private void dragDropInput_DragEnter(object sender, DragEventArgs e)
        {
            dragDropInput.BackColor = Color.LightGreen;
            e.Effect = DragDropEffects.All;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            HideDocumentMetadata();
            HideOptions();
        }

        private void GetDocumentData(DragEventArgs e)
        {
            string docPath = "";
            string docName = "";
            string docText = "";

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            docPath = files[0].ToString();
            docName = docPath.Substring(docPath.LastIndexOf('\\') + 1);
            docText = System.IO.File.ReadAllText(docPath);

            UploadedDocument.setUploadedDocument(docName, docPath, docText);
            
            documentTitle.Text = UploadedDocument.getFileName();
            documentPath.Text = UploadedDocument.getFilePath();
            documentContentTextBox.Text = UploadedDocument.getFileContent();
        }

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
            UploadedDocument.cleanData();
            documentContentTextBox.Clear();
        }

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

        private void ShowOptions()
        {
            optionsGroupBox.Visible = true;
        }

        private void HideOptions()
        {
            optionsGroupBox.Visible = false;
        }

        private void signDocumentButton_Click(object sender, EventArgs e)
        {
            cryptographyRSAClass getRSAKeys = new cryptographyRSAClass();
            string keys = getRSAKeys.getKeys();
        }
    }
}