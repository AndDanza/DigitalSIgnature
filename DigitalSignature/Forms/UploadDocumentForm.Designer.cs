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
            this.documentPath = new System.Windows.Forms.Label();
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
            this.documentContentLable.Location = new System.Drawing.Point(251, 304);
            this.documentContentLable.Name = "documentContentLable";
            this.documentContentLable.Size = new System.Drawing.Size(123, 17);
            this.documentContentLable.TabIndex = 4;
            this.documentContentLable.Text = "Document content";
            this.documentContentLable.Visible = false;
            // 
            // documentContentTextBox
            // 
            this.documentContentTextBox.Location = new System.Drawing.Point(254, 324);
            this.documentContentTextBox.Multiline = true;
            this.documentContentTextBox.Name = "documentContentTextBox";
            this.documentContentTextBox.ReadOnly = true;
            this.documentContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.documentContentTextBox.Size = new System.Drawing.Size(588, 182);
            this.documentContentTextBox.TabIndex = 2;
            this.documentContentTextBox.Visible = false;
            // 
            // dragDropLabel
            // 
            this.dragDropLabel.AllowDrop = true;
            this.dragDropLabel.AutoSize = true;
            this.dragDropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragDropLabel.Location = new System.Drawing.Point(142, 68);
            this.dragDropLabel.Name = "dragDropLabel";
            this.dragDropLabel.Size = new System.Drawing.Size(289, 32);
            this.dragDropLabel.TabIndex = 0;
            this.dragDropLabel.Text = "Drop file in this area";
            // 
            // uplodedDocument
            // 
            this.uplodedDocument.Controls.Add(this.removeButton);
            this.uplodedDocument.Controls.Add(this.documentIconPicture);
            this.uplodedDocument.Controls.Add(this.documentPath);
            this.uplodedDocument.Controls.Add(this.documentTitle);
            this.uplodedDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uplodedDocument.Location = new System.Drawing.Point(16, 13);
            this.uplodedDocument.Name = "uplodedDocument";
            this.uplodedDocument.Size = new System.Drawing.Size(557, 139);
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
            this.removeButton.Location = new System.Drawing.Point(505, 47);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(46, 40);
            this.removeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removeButton.TabIndex = 2;
            this.removeButton.TabStop = false;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // documentIconPicture
            // 
            this.documentIconPicture.Image = global::DigitalSignature.Properties.Resources._12_File_512;
            this.documentIconPicture.Location = new System.Drawing.Point(14, 36);
            this.documentIconPicture.Name = "documentIconPicture";
            this.documentIconPicture.Size = new System.Drawing.Size(82, 81);
            this.documentIconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.documentIconPicture.TabIndex = 1;
            this.documentIconPicture.TabStop = false;
            // 
            // documentPath
            // 
            this.documentPath.AutoSize = true;
            this.documentPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentPath.Location = new System.Drawing.Point(116, 80);
            this.documentPath.Name = "documentPath";
            this.documentPath.Size = new System.Drawing.Size(46, 17);
            this.documentPath.TabIndex = 4;
            this.documentPath.Text = "label1";
            // 
            // documentTitle
            // 
            this.documentTitle.AutoSize = true;
            this.documentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentTitle.Location = new System.Drawing.Point(115, 48);
            this.documentTitle.Name = "documentTitle";
            this.documentTitle.Size = new System.Drawing.Size(53, 20);
            this.documentTitle.TabIndex = 3;
            this.documentTitle.Text = "label1";
            // 
            // dragDropInput
            // 
            this.dragDropInput.AllowDrop = true;
            this.dragDropInput.Controls.Add(this.uplodedDocument);
            this.dragDropInput.Controls.Add(this.dragDropLabel);
            this.dragDropInput.Location = new System.Drawing.Point(254, 112);
            this.dragDropInput.Name = "dragDropInput";
            this.dragDropInput.Size = new System.Drawing.Size(588, 162);
            this.dragDropInput.TabIndex = 1;
            this.dragDropInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropInput_DragDrop);
            this.dragDropInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDropInput_DragEnter);
            this.dragDropInput.DragLeave += new System.EventHandler(this.dragDropInput_DragLeave);
            // 
            // headlineLable
            // 
            this.headlineLable.AutoSize = true;
            this.headlineLable.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.headlineLable.Font = new System.Drawing.Font("Lucida Calligraphy", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlineLable.Location = new System.Drawing.Point(218, 18);
            this.headlineLable.Name = "headlineLable";
            this.headlineLable.Size = new System.Drawing.Size(443, 56);
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
            this.panelOptions.Location = new System.Drawing.Point(-4, 1);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(225, 618);
            this.panelOptions.TabIndex = 6;
            // 
            // optionsPanel
            // 
            this.optionsPanel.AutoSize = true;
            this.optionsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsPanel.Location = new System.Drawing.Point(49, 107);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(125, 36);
            this.optionsPanel.TabIndex = 28;
            this.optionsPanel.Text = "Options";
            // 
            // sha1DigestLable
            // 
            this.sha1DigestLable.AutoSize = true;
            this.sha1DigestLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha1DigestLable.Location = new System.Drawing.Point(16, 514);
            this.sha1DigestLable.Name = "sha1DigestLable";
            this.sha1DigestLable.Size = new System.Drawing.Size(68, 24);
            this.sha1DigestLable.TabIndex = 27;
            this.sha1DigestLable.Text = "Digest";
            // 
            // optionSHA1Digest
            // 
            this.optionSHA1Digest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionSHA1Digest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionSHA1Digest.Location = new System.Drawing.Point(42, 541);
            this.optionSHA1Digest.Name = "optionSHA1Digest";
            this.optionSHA1Digest.Size = new System.Drawing.Size(154, 34);
            this.optionSHA1Digest.TabIndex = 26;
            this.optionSHA1Digest.Text = "SHA-1";
            this.optionSHA1Digest.UseVisualStyleBackColor = true;
            this.optionSHA1Digest.Click += new System.EventHandler(this.optionSHA1Digest_Click);
            // 
            // digitalSignatureLabel
            // 
            this.digitalSignatureLabel.AutoSize = true;
            this.digitalSignatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalSignatureLabel.Location = new System.Drawing.Point(16, 394);
            this.digitalSignatureLabel.Name = "digitalSignatureLabel";
            this.digitalSignatureLabel.Size = new System.Drawing.Size(52, 24);
            this.digitalSignatureLabel.TabIndex = 25;
            this.digitalSignatureLabel.Text = "Sign";
            // 
            // optionValidateDocument
            // 
            this.optionValidateDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionValidateDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionValidateDocument.Location = new System.Drawing.Point(42, 461);
            this.optionValidateDocument.Name = "optionValidateDocument";
            this.optionValidateDocument.Size = new System.Drawing.Size(154, 34);
            this.optionValidateDocument.TabIndex = 24;
            this.optionValidateDocument.Text = "Validate";
            this.optionValidateDocument.UseVisualStyleBackColor = true;
            this.optionValidateDocument.Click += new System.EventHandler(this.optionValidateDocument_Click);
            // 
            // optionSignDocument
            // 
            this.optionSignDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionSignDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionSignDocument.Location = new System.Drawing.Point(42, 421);
            this.optionSignDocument.Name = "optionSignDocument";
            this.optionSignDocument.Size = new System.Drawing.Size(154, 34);
            this.optionSignDocument.TabIndex = 23;
            this.optionSignDocument.Text = "Sign";
            this.optionSignDocument.UseVisualStyleBackColor = true;
            this.optionSignDocument.Click += new System.EventHandler(this.optionSignDocument_Click);
            // 
            // decryptLable
            // 
            this.decryptLable.AutoSize = true;
            this.decryptLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptLable.Location = new System.Drawing.Point(16, 277);
            this.decryptLable.Name = "decryptLable";
            this.decryptLable.Size = new System.Drawing.Size(81, 24);
            this.decryptLable.TabIndex = 22;
            this.decryptLable.Text = "Decrypt";
            // 
            // optionDecryptAES
            // 
            this.optionDecryptAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionDecryptAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionDecryptAES.Location = new System.Drawing.Point(42, 344);
            this.optionDecryptAES.Name = "optionDecryptAES";
            this.optionDecryptAES.Size = new System.Drawing.Size(154, 34);
            this.optionDecryptAES.TabIndex = 21;
            this.optionDecryptAES.Text = "AES";
            this.optionDecryptAES.UseVisualStyleBackColor = true;
            this.optionDecryptAES.Click += new System.EventHandler(this.optionDecryptAES_Click);
            // 
            // optionDecryptRSA
            // 
            this.optionDecryptRSA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionDecryptRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionDecryptRSA.Location = new System.Drawing.Point(42, 304);
            this.optionDecryptRSA.Name = "optionDecryptRSA";
            this.optionDecryptRSA.Size = new System.Drawing.Size(154, 34);
            this.optionDecryptRSA.TabIndex = 20;
            this.optionDecryptRSA.Text = "RSA";
            this.optionDecryptRSA.UseVisualStyleBackColor = true;
            this.optionDecryptRSA.Click += new System.EventHandler(this.optionDecryptRSA_Click);
            // 
            // encryptLable
            // 
            this.encryptLable.AutoSize = true;
            this.encryptLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptLable.Location = new System.Drawing.Point(16, 162);
            this.encryptLable.Name = "encryptLable";
            this.encryptLable.Size = new System.Drawing.Size(81, 24);
            this.encryptLable.TabIndex = 19;
            this.encryptLable.Text = "Encrypt";
            // 
            // optionEncryptAES
            // 
            this.optionEncryptAES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionEncryptAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.optionEncryptAES.Location = new System.Drawing.Point(42, 229);
            this.optionEncryptAES.Name = "optionEncryptAES";
            this.optionEncryptAES.Size = new System.Drawing.Size(154, 34);
            this.optionEncryptAES.TabIndex = 18;
            this.optionEncryptAES.Text = "AES";
            this.optionEncryptAES.UseVisualStyleBackColor = true;
            this.optionEncryptAES.Click += new System.EventHandler(this.optionEncryptAES_Click);
            // 
            // optionEncryptRSA
            // 
            this.optionEncryptRSA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionEncryptRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionEncryptRSA.Location = new System.Drawing.Point(42, 189);
            this.optionEncryptRSA.Name = "optionEncryptRSA";
            this.optionEncryptRSA.Size = new System.Drawing.Size(154, 34);
            this.optionEncryptRSA.TabIndex = 17;
            this.optionEncryptRSA.Text = "RSA";
            this.optionEncryptRSA.UseVisualStyleBackColor = true;
            this.optionEncryptRSA.Click += new System.EventHandler(this.optionEncryptRSA_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.headlineLable);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 90);
            this.panel1.TabIndex = 7;
            // 
            // UploadDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 616);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.documentContentLable);
            this.Controls.Add(this.documentContentTextBox);
            this.Controls.Add(this.dragDropInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label documentPath;
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
    }
}