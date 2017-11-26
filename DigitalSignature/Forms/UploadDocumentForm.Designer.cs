namespace DigitalSignature.Forms
{
    partial class UploadDocumentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.documentContentLable = new System.Windows.Forms.Label();
            this.documentContentTextBox = new System.Windows.Forms.TextBox();
            this.dragDropLabel = new System.Windows.Forms.Label();
            this.uplodedDocument = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.PictureBox();
            this.documentIconPicture = new System.Windows.Forms.PictureBox();
            this.documentTitle = new System.Windows.Forms.Label();
            this.dragDropInput = new System.Windows.Forms.Panel();
            this.headlineLable = new System.Windows.Forms.Label();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.optionsPanel = new System.Windows.Forms.Label();
            this.sha1DigestLable = new System.Windows.Forms.Label();
            this.optionSHA1Digest = new System.Windows.Forms.Button();
            this.digitalSignatureLabel = new System.Windows.Forms.Label();
            this.optionValidateDocument = new System.Windows.Forms.Button();
            this.optionSignDocument = new System.Windows.Forms.Button();
            this.decryptLable = new System.Windows.Forms.Label();
            this.optionDecryptAES = new System.Windows.Forms.Button();
            this.optionDecryptRSA = new System.Windows.Forms.Button();
            this.encryptLable = new System.Windows.Forms.Label();
            this.optionEncryptAES = new System.Windows.Forms.Button();
            this.optionEncryptRSA = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.documentPath = new System.Windows.Forms.TextBox();
            this.outputScreen = new System.Windows.Forms.TextBox();
            this.outPutScreenLable = new System.Windows.Forms.Label();
            this.uplodedDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentIconPicture)).BeginInit();
            this.dragDropInput.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentContentLable
            // 
            this.documentContentLable.AutoSize = true;
            this.documentContentLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentContentLable.Location = new System.Drawing.Point(187, 232);
            this.documentContentLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.documentContentLable.Name = "documentContentLable";
            this.documentContentLable.Size = new System.Drawing.Size(111, 13);
            this.documentContentLable.TabIndex = 4;
            this.documentContentLable.Text = "Document content";
            this.documentContentLable.Visible = false;
            // 
            // documentContentTextBox
            // 
            this.documentContentTextBox.Location = new System.Drawing.Point(189, 248);
            this.documentContentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.documentContentTextBox.Multiline = true;
            this.documentContentTextBox.Name = "documentContentTextBox";
            this.documentContentTextBox.ReadOnly = true;
            this.documentContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.documentContentTextBox.Size = new System.Drawing.Size(442, 103);
            this.documentContentTextBox.TabIndex = 2;
            this.documentContentTextBox.Visible = false;
            // 
            // dragDropLabel
            // 
            this.dragDropLabel.AllowDrop = true;
            this.dragDropLabel.AutoSize = true;
            this.dragDropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragDropLabel.Location = new System.Drawing.Point(106, 55);
            this.dragDropLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dragDropLabel.Name = "dragDropLabel";
            this.dragDropLabel.Size = new System.Drawing.Size(227, 26);
            this.dragDropLabel.TabIndex = 0;
            this.dragDropLabel.Text = "Drop file in this area";
            // 
            // uplodedDocument
            // 
            this.uplodedDocument.Controls.Add(this.documentPath);
            this.uplodedDocument.Controls.Add(this.removeButton);
            this.uplodedDocument.Controls.Add(this.documentIconPicture);
            this.uplodedDocument.Controls.Add(this.documentTitle);
            this.uplodedDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uplodedDocument.Location = new System.Drawing.Point(12, 8);
            this.uplodedDocument.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uplodedDocument.Name = "uplodedDocument";
            this.uplodedDocument.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uplodedDocument.Size = new System.Drawing.Size(418, 108);
            this.uplodedDocument.TabIndex = 5;
            this.uplodedDocument.TabStop = false;
            this.uplodedDocument.Text = "Uploded Document";
            this.uplodedDocument.Visible = false;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeButton.BackColor = System.Drawing.Color.Transparent;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Image = global::DigitalSignature.Properties.Resources._39;
            this.removeButton.Location = new System.Drawing.Point(388, 24);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(26, 29);
            this.removeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removeButton.TabIndex = 2;
            this.removeButton.TabStop = false;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // documentIconPicture
            // 
            this.documentIconPicture.Image = global::DigitalSignature.Properties.Resources._12_File_512;
            this.documentIconPicture.Location = new System.Drawing.Point(11, 29);
            this.documentIconPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.documentIconPicture.Name = "documentIconPicture";
            this.documentIconPicture.Size = new System.Drawing.Size(62, 61);
            this.documentIconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.documentIconPicture.TabIndex = 1;
            this.documentIconPicture.TabStop = false;
            // 
            // documentTitle
            // 
            this.documentTitle.AutoSize = true;
            this.documentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentTitle.Location = new System.Drawing.Point(86, 29);
            this.documentTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.documentTitle.Name = "documentTitle";
            this.documentTitle.Size = new System.Drawing.Size(46, 17);
            this.documentTitle.TabIndex = 3;
            this.documentTitle.Text = "label1";
            // 
            // dragDropInput
            // 
            this.dragDropInput.AllowDrop = true;
            this.dragDropInput.Controls.Add(this.uplodedDocument);
            this.dragDropInput.Controls.Add(this.dragDropLabel);
            this.dragDropInput.Location = new System.Drawing.Point(190, 91);
            this.dragDropInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dragDropInput.Name = "dragDropInput";
            this.dragDropInput.Size = new System.Drawing.Size(441, 124);
            this.dragDropInput.TabIndex = 1;
            this.dragDropInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropInput_DragDrop);
            this.dragDropInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragDropInput_DragEnter);
            this.dragDropInput.DragLeave += new System.EventHandler(this.DragDropInput_DragLeave);
            // 
            // headlineLable
            // 
            this.headlineLable.AutoSize = true;
            this.headlineLable.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headlineLable.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlineLable.Location = new System.Drawing.Point(164, 15);
            this.headlineLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headlineLable.Name = "headlineLable";
            this.headlineLable.Size = new System.Drawing.Size(322, 39);
            this.headlineLable.TabIndex = 5;
            this.headlineLable.Text = "Digital Signature";
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelOptions.Controls.Add(this.optionsPanel);
            this.panelOptions.Controls.Add(this.sha1DigestLable);
            this.panelOptions.Controls.Add(this.optionSHA1Digest);
            this.panelOptions.Controls.Add(this.digitalSignatureLabel);
            this.panelOptions.Controls.Add(this.optionValidateDocument);
            this.panelOptions.Controls.Add(this.optionSignDocument);
            this.panelOptions.Controls.Add(this.decryptLable);
            this.panelOptions.Controls.Add(this.optionDecryptAES);
            this.panelOptions.Controls.Add(this.optionDecryptRSA);
            this.panelOptions.Controls.Add(this.encryptLable);
            this.panelOptions.Controls.Add(this.optionEncryptAES);
            this.panelOptions.Controls.Add(this.optionEncryptRSA);
            this.panelOptions.Enabled = false;
            this.panelOptions.Location = new System.Drawing.Point(-3, 1);
            this.panelOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(169, 502);
            this.panelOptions.TabIndex = 6;
            // 
            // optionsPanel
            // 
            this.optionsPanel.AutoSize = true;
            this.optionsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsPanel.Location = new System.Drawing.Point(37, 87);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(104, 29);
            this.optionsPanel.TabIndex = 28;
            this.optionsPanel.Text = "Options";
            // 
            // sha1DigestLable
            // 
            this.sha1DigestLable.AutoSize = true;
            this.sha1DigestLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha1DigestLable.Location = new System.Drawing.Point(12, 418);
            this.sha1DigestLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sha1DigestLable.Name = "sha1DigestLable";
            this.sha1DigestLable.Size = new System.Drawing.Size(56, 18);
            this.sha1DigestLable.TabIndex = 27;
            this.sha1DigestLable.Text = "Digest";
            // 
            // optionSHA1Digest
            // 
            this.optionSHA1Digest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionSHA1Digest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionSHA1Digest.Location = new System.Drawing.Point(32, 440);
            this.optionSHA1Digest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionSHA1Digest.Name = "optionSHA1Digest";
            this.optionSHA1Digest.Size = new System.Drawing.Size(116, 28);
            this.optionSHA1Digest.TabIndex = 26;
            this.optionSHA1Digest.Text = "SHA-1";
            this.optionSHA1Digest.UseVisualStyleBackColor = true;
            this.optionSHA1Digest.Click += new System.EventHandler(this.OptionSHA1Digest_Click);
            // 
            // digitalSignatureLabel
            // 
            this.digitalSignatureLabel.AutoSize = true;
            this.digitalSignatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalSignatureLabel.Location = new System.Drawing.Point(12, 320);
            this.digitalSignatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.digitalSignatureLabel.Name = "digitalSignatureLabel";
            this.digitalSignatureLabel.Size = new System.Drawing.Size(41, 18);
            this.digitalSignatureLabel.TabIndex = 25;
            this.digitalSignatureLabel.Text = "Sign";
            // 
            // optionValidateDocument
            // 
            this.optionValidateDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionValidateDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionValidateDocument.Location = new System.Drawing.Point(32, 375);
            this.optionValidateDocument.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionValidateDocument.Name = "optionValidateDocument";
            this.optionValidateDocument.Size = new System.Drawing.Size(116, 28);
            this.optionValidateDocument.TabIndex = 24;
            this.optionValidateDocument.Text = "Validate";
            this.optionValidateDocument.UseVisualStyleBackColor = true;
            this.optionValidateDocument.Click += new System.EventHandler(this.OptionValidateDocument_Click);
            // 
            // optionSignDocument
            // 
            this.optionSignDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionSignDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionSignDocument.Location = new System.Drawing.Point(32, 342);
            this.optionSignDocument.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionSignDocument.Name = "optionSignDocument";
            this.optionSignDocument.Size = new System.Drawing.Size(116, 28);
            this.optionSignDocument.TabIndex = 23;
            this.optionSignDocument.Text = "Sign";
            this.optionSignDocument.UseVisualStyleBackColor = true;
            this.optionSignDocument.Click += new System.EventHandler(this.OptionSignDocument_Click);
            // 
            // decryptLable
            // 
            this.decryptLable.AutoSize = true;
            this.decryptLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptLable.Location = new System.Drawing.Point(12, 225);
            this.decryptLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.decryptLable.Name = "decryptLable";
            this.decryptLable.Size = new System.Drawing.Size(66, 18);
            this.decryptLable.TabIndex = 22;
            this.decryptLable.Text = "Decrypt";
            // 
            // optionDecryptAES
            // 
            this.optionDecryptAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionDecryptAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionDecryptAES.Location = new System.Drawing.Point(32, 280);
            this.optionDecryptAES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionDecryptAES.Name = "optionDecryptAES";
            this.optionDecryptAES.Size = new System.Drawing.Size(116, 28);
            this.optionDecryptAES.TabIndex = 21;
            this.optionDecryptAES.Text = "AES";
            this.optionDecryptAES.UseVisualStyleBackColor = true;
            this.optionDecryptAES.Click += new System.EventHandler(this.OptionDecryptAES_Click);
            // 
            // optionDecryptRSA
            // 
            this.optionDecryptRSA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionDecryptRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionDecryptRSA.Location = new System.Drawing.Point(32, 247);
            this.optionDecryptRSA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionDecryptRSA.Name = "optionDecryptRSA";
            this.optionDecryptRSA.Size = new System.Drawing.Size(116, 28);
            this.optionDecryptRSA.TabIndex = 20;
            this.optionDecryptRSA.Text = "RSA";
            this.optionDecryptRSA.UseVisualStyleBackColor = true;
            this.optionDecryptRSA.Click += new System.EventHandler(this.OptionDecryptRSA_Click);
            // 
            // encryptLable
            // 
            this.encryptLable.AutoSize = true;
            this.encryptLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptLable.Location = new System.Drawing.Point(12, 132);
            this.encryptLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.encryptLable.Name = "encryptLable";
            this.encryptLable.Size = new System.Drawing.Size(65, 18);
            this.encryptLable.TabIndex = 19;
            this.encryptLable.Text = "Encrypt";
            // 
            // optionEncryptAES
            // 
            this.optionEncryptAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionEncryptAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionEncryptAES.Location = new System.Drawing.Point(32, 186);
            this.optionEncryptAES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionEncryptAES.Name = "optionEncryptAES";
            this.optionEncryptAES.Size = new System.Drawing.Size(116, 28);
            this.optionEncryptAES.TabIndex = 18;
            this.optionEncryptAES.Text = "AES";
            this.optionEncryptAES.UseVisualStyleBackColor = true;
            this.optionEncryptAES.Click += new System.EventHandler(this.OptionEncryptAES_Click);
            // 
            // optionEncryptRSA
            // 
            this.optionEncryptRSA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionEncryptRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionEncryptRSA.Location = new System.Drawing.Point(32, 154);
            this.optionEncryptRSA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionEncryptRSA.Name = "optionEncryptRSA";
            this.optionEncryptRSA.Size = new System.Drawing.Size(116, 28);
            this.optionEncryptRSA.TabIndex = 17;
            this.optionEncryptRSA.Text = "RSA";
            this.optionEncryptRSA.UseVisualStyleBackColor = true;
            this.optionEncryptRSA.Click += new System.EventHandler(this.OptionEncryptRSA_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.headlineLable);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 73);
            this.panel1.TabIndex = 7;
            // 
            // documentPath
            // 
            this.documentPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.documentPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.documentPath.Enabled = false;
            this.documentPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentPath.Location = new System.Drawing.Point(89, 49);
            this.documentPath.Multiline = true;
            this.documentPath.Name = "documentPath";
            this.documentPath.ReadOnly = true;
            this.documentPath.Size = new System.Drawing.Size(276, 43);
            this.documentPath.TabIndex = 5;
            // 
            // outputScreen
            // 
            this.outputScreen.Location = new System.Drawing.Point(190, 386);
            this.outputScreen.Multiline = true;
            this.outputScreen.Name = "outputScreen";
            this.outputScreen.ReadOnly = true;
            this.outputScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputScreen.Size = new System.Drawing.Size(440, 97);
            this.outputScreen.TabIndex = 8;
            this.outputScreen.Visible = false;
            // 
            // outPutScreenLable
            // 
            this.outPutScreenLable.AutoSize = true;
            this.outPutScreenLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outPutScreenLable.Location = new System.Drawing.Point(187, 370);
            this.outPutScreenLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outPutScreenLable.Name = "outPutScreenLable";
            this.outPutScreenLable.Size = new System.Drawing.Size(87, 13);
            this.outPutScreenLable.TabIndex = 9;
            this.outPutScreenLable.Text = "Output screen";
            this.outPutScreenLable.Visible = false;
            // 
            // UploadDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(660, 500);
            this.ControlBox = false;
            this.Controls.Add(this.outPutScreenLable);
            this.Controls.Add(this.outputScreen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.documentContentLable);
            this.Controls.Add(this.documentContentTextBox);
            this.Controls.Add(this.dragDropInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UploadDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignDocumentForm";
            this.uplodedDocument.ResumeLayout(false);
            this.uplodedDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentIconPicture)).EndInit();
            this.dragDropInput.ResumeLayout(false);
            this.dragDropInput.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label documentContentLable;
        private System.Windows.Forms.TextBox documentContentTextBox;
        private System.Windows.Forms.Label dragDropLabel;
        private System.Windows.Forms.GroupBox uplodedDocument;
        private System.Windows.Forms.PictureBox documentIconPicture;
        private System.Windows.Forms.Label documentTitle;
        private System.Windows.Forms.PictureBox removeButton;
        private System.Windows.Forms.Panel dragDropInput;
        private System.Windows.Forms.Label headlineLable;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Label optionsPanel;
        private System.Windows.Forms.Label sha1DigestLable;
        private System.Windows.Forms.Button optionSHA1Digest;
        private System.Windows.Forms.Label digitalSignatureLabel;
        private System.Windows.Forms.Button optionValidateDocument;
        private System.Windows.Forms.Button optionSignDocument;
        private System.Windows.Forms.Label decryptLable;
        private System.Windows.Forms.Button optionDecryptAES;
        private System.Windows.Forms.Button optionDecryptRSA;
        private System.Windows.Forms.Label encryptLable;
        private System.Windows.Forms.Button optionEncryptAES;
        private System.Windows.Forms.Button optionEncryptRSA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox documentPath;
        private System.Windows.Forms.TextBox outputScreen;
        private System.Windows.Forms.Label outPutScreenLable;
    }
}