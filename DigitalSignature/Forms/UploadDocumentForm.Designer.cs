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
            this.documentPath = new System.Windows.Forms.Label();
            this.documentTitle = new System.Windows.Forms.Label();
            this.dragDropInput = new System.Windows.Forms.Panel();
            this.encryptGroupBox = new System.Windows.Forms.GroupBox();
            this.encryptAESButton = new System.Windows.Forms.Button();
            this.encryptRSAButton = new System.Windows.Forms.Button();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.shaDigestButton = new System.Windows.Forms.Button();
            this.signatureGroupBox = new System.Windows.Forms.GroupBox();
            this.validateDocButton = new System.Windows.Forms.Button();
            this.signDocButton = new System.Windows.Forms.Button();
            this.decryptGroupBox = new System.Windows.Forms.GroupBox();
            this.decryptAESButton = new System.Windows.Forms.Button();
            this.decryptRSAButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.PictureBox();
            this.documentIconPicture = new System.Windows.Forms.PictureBox();
            this.uplodedDocument.SuspendLayout();
            this.dragDropInput.SuspendLayout();
            this.encryptGroupBox.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.signatureGroupBox.SuspendLayout();
            this.decryptGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentIconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // documentContentLable
            // 
            this.documentContentLable.AutoSize = true;
            this.documentContentLable.Location = new System.Drawing.Point(44, 185);
            this.documentContentLable.Name = "documentContentLable";
            this.documentContentLable.Size = new System.Drawing.Size(123, 17);
            this.documentContentLable.TabIndex = 4;
            this.documentContentLable.Text = "Document content";
            this.documentContentLable.Visible = false;
            // 
            // documentContentTextBox
            // 
            this.documentContentTextBox.Location = new System.Drawing.Point(44, 208);
            this.documentContentTextBox.Multiline = true;
            this.documentContentTextBox.Name = "documentContentTextBox";
            this.documentContentTextBox.ReadOnly = true;
            this.documentContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.documentContentTextBox.Size = new System.Drawing.Size(796, 141);
            this.documentContentTextBox.TabIndex = 2;
            this.documentContentTextBox.Visible = false;
            // 
            // dragDropLabel
            // 
            this.dragDropLabel.AllowDrop = true;
            this.dragDropLabel.AutoSize = true;
            this.dragDropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragDropLabel.Location = new System.Drawing.Point(250, 55);
            this.dragDropLabel.Name = "dragDropLabel";
            this.dragDropLabel.Size = new System.Drawing.Size(289, 32);
            this.dragDropLabel.TabIndex = 0;
            this.dragDropLabel.Text = "Drop file in this area";
            // 
            // uplodedDocument
            // 
            this.uplodedDocument.Controls.Add(this.documentIconPicture);
            this.uplodedDocument.Controls.Add(this.documentPath);
            this.uplodedDocument.Controls.Add(this.documentTitle);
            this.uplodedDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uplodedDocument.Location = new System.Drawing.Point(16, 7);
            this.uplodedDocument.Name = "uplodedDocument";
            this.uplodedDocument.Size = new System.Drawing.Size(672, 130);
            this.uplodedDocument.TabIndex = 5;
            this.uplodedDocument.TabStop = false;
            this.uplodedDocument.Text = "Uploded Document";
            this.uplodedDocument.Visible = false;
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
            this.dragDropInput.Controls.Add(this.removeButton);
            this.dragDropInput.Controls.Add(this.uplodedDocument);
            this.dragDropInput.Controls.Add(this.dragDropLabel);
            this.dragDropInput.Location = new System.Drawing.Point(47, 21);
            this.dragDropInput.Name = "dragDropInput";
            this.dragDropInput.Size = new System.Drawing.Size(793, 145);
            this.dragDropInput.TabIndex = 1;
            this.dragDropInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropInput_DragDrop);
            this.dragDropInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDropInput_DragEnter);
            this.dragDropInput.DragLeave += new System.EventHandler(this.dragDropInput_DragLeave);
            // 
            // encryptGroupBox
            // 
            this.encryptGroupBox.Controls.Add(this.encryptAESButton);
            this.encryptGroupBox.Controls.Add(this.encryptRSAButton);
            this.encryptGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptGroupBox.Location = new System.Drawing.Point(15, 50);
            this.encryptGroupBox.Name = "encryptGroupBox";
            this.encryptGroupBox.Size = new System.Drawing.Size(181, 168);
            this.encryptGroupBox.TabIndex = 5;
            this.encryptGroupBox.TabStop = false;
            this.encryptGroupBox.Text = "Encrypt";
            // 
            // encryptAESButton
            // 
            this.encryptAESButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptAESButton.Location = new System.Drawing.Point(14, 98);
            this.encryptAESButton.Name = "encryptAESButton";
            this.encryptAESButton.Size = new System.Drawing.Size(154, 51);
            this.encryptAESButton.TabIndex = 1;
            this.encryptAESButton.Text = "AES";
            this.encryptAESButton.UseVisualStyleBackColor = true;
            // 
            // encryptRSAButton
            // 
            this.encryptRSAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptRSAButton.Location = new System.Drawing.Point(14, 36);
            this.encryptRSAButton.Name = "encryptRSAButton";
            this.encryptRSAButton.Size = new System.Drawing.Size(154, 51);
            this.encryptRSAButton.TabIndex = 0;
            this.encryptRSAButton.Text = "RSA";
            this.encryptRSAButton.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.shaDigestButton);
            this.optionsGroupBox.Controls.Add(this.signatureGroupBox);
            this.optionsGroupBox.Controls.Add(this.decryptGroupBox);
            this.optionsGroupBox.Controls.Add(this.encryptGroupBox);
            this.optionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsGroupBox.Location = new System.Drawing.Point(44, 368);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(796, 236);
            this.optionsGroupBox.TabIndex = 6;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            this.optionsGroupBox.Visible = false;
            // 
            // shaDigestButton
            // 
            this.shaDigestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shaDigestButton.Location = new System.Drawing.Point(631, 104);
            this.shaDigestButton.Name = "shaDigestButton";
            this.shaDigestButton.Size = new System.Drawing.Size(154, 51);
            this.shaDigestButton.TabIndex = 2;
            this.shaDigestButton.Text = "SHA-1";
            this.shaDigestButton.UseVisualStyleBackColor = true;
            this.shaDigestButton.Click += new System.EventHandler(this.shaDigestButton_Click);
            // 
            // signatureGroupBox
            // 
            this.signatureGroupBox.Controls.Add(this.validateDocButton);
            this.signatureGroupBox.Controls.Add(this.signDocButton);
            this.signatureGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signatureGroupBox.Location = new System.Drawing.Point(435, 50);
            this.signatureGroupBox.Name = "signatureGroupBox";
            this.signatureGroupBox.Size = new System.Drawing.Size(181, 168);
            this.signatureGroupBox.TabIndex = 6;
            this.signatureGroupBox.TabStop = false;
            this.signatureGroupBox.Text = "Signature";
            // 
            // validateDocButton
            // 
            this.validateDocButton.Location = new System.Drawing.Point(14, 98);
            this.validateDocButton.Name = "validateDocButton";
            this.validateDocButton.Size = new System.Drawing.Size(154, 51);
            this.validateDocButton.TabIndex = 1;
            this.validateDocButton.Text = "Validate";
            this.validateDocButton.UseVisualStyleBackColor = true;
            // 
            // signDocButton
            // 
            this.signDocButton.Location = new System.Drawing.Point(14, 36);
            this.signDocButton.Name = "signDocButton";
            this.signDocButton.Size = new System.Drawing.Size(154, 51);
            this.signDocButton.TabIndex = 0;
            this.signDocButton.Text = "Sign";
            this.signDocButton.UseVisualStyleBackColor = true;
            // 
            // decryptGroupBox
            // 
            this.decryptGroupBox.Controls.Add(this.decryptAESButton);
            this.decryptGroupBox.Controls.Add(this.decryptRSAButton);
            this.decryptGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptGroupBox.Location = new System.Drawing.Point(227, 50);
            this.decryptGroupBox.Name = "decryptGroupBox";
            this.decryptGroupBox.Size = new System.Drawing.Size(181, 168);
            this.decryptGroupBox.TabIndex = 6;
            this.decryptGroupBox.TabStop = false;
            this.decryptGroupBox.Text = "Decrypt";
            // 
            // decryptAESButton
            // 
            this.decryptAESButton.Location = new System.Drawing.Point(14, 98);
            this.decryptAESButton.Name = "decryptAESButton";
            this.decryptAESButton.Size = new System.Drawing.Size(154, 51);
            this.decryptAESButton.TabIndex = 1;
            this.decryptAESButton.Text = "AES";
            this.decryptAESButton.UseVisualStyleBackColor = true;
            // 
            // decryptRSAButton
            // 
            this.decryptRSAButton.Location = new System.Drawing.Point(14, 36);
            this.decryptRSAButton.Name = "decryptRSAButton";
            this.decryptRSAButton.Size = new System.Drawing.Size(154, 51);
            this.decryptRSAButton.TabIndex = 0;
            this.decryptRSAButton.Text = "RSA";
            this.decryptRSAButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Transparent;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Image = global::DigitalSignature.Properties.Resources._39;
            this.removeButton.Location = new System.Drawing.Point(713, 43);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(55, 50);
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
            // UploadDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(880, 616);
            this.ControlBox = false;
            this.Controls.Add(this.documentContentLable);
            this.Controls.Add(this.documentContentTextBox);
            this.Controls.Add(this.dragDropInput);
            this.Controls.Add(this.optionsGroupBox);
            this.Name = "UploadDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignDocumentForm";
            this.uplodedDocument.ResumeLayout(false);
            this.uplodedDocument.PerformLayout();
            this.dragDropInput.ResumeLayout(false);
            this.dragDropInput.PerformLayout();
            this.encryptGroupBox.ResumeLayout(false);
            this.optionsGroupBox.ResumeLayout(false);
            this.signatureGroupBox.ResumeLayout(false);
            this.decryptGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentIconPicture)).EndInit();
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
        private System.Windows.Forms.GroupBox encryptGroupBox;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.Button encryptAESButton;
        private System.Windows.Forms.Button encryptRSAButton;
        private System.Windows.Forms.GroupBox signatureGroupBox;
        private System.Windows.Forms.Button validateDocButton;
        private System.Windows.Forms.Button signDocButton;
        private System.Windows.Forms.GroupBox decryptGroupBox;
        private System.Windows.Forms.Button decryptAESButton;
        private System.Windows.Forms.Button decryptRSAButton;
        private System.Windows.Forms.Button shaDigestButton;
    }
}