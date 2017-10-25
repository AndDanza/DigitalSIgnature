namespace DigitalSignature.Forms
{
    partial class SignDocumentForm
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
            this.dragDropInput = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.PictureBox();
            this.uplodedDocument = new System.Windows.Forms.GroupBox();
            this.documentIconPicture = new System.Windows.Forms.PictureBox();
            this.documentPath = new System.Windows.Forms.Label();
            this.documentTitle = new System.Windows.Forms.Label();
            this.dragDropLabel = new System.Windows.Forms.Label();
            this.documentContentTextBox = new System.Windows.Forms.TextBox();
            this.signDocumentButton = new System.Windows.Forms.PictureBox();
            this.documentContentLable = new System.Windows.Forms.Label();
            this.dragDropInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).BeginInit();
            this.uplodedDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentIconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signDocumentButton)).BeginInit();
            this.SuspendLayout();
            // 
            // dragDropInput
            // 
            this.dragDropInput.AllowDrop = true;
            this.dragDropInput.Controls.Add(this.removeButton);
            this.dragDropInput.Controls.Add(this.uplodedDocument);
            this.dragDropInput.Controls.Add(this.dragDropLabel);
            this.dragDropInput.Location = new System.Drawing.Point(35, 36);
            this.dragDropInput.Name = "dragDropInput";
            this.dragDropInput.Size = new System.Drawing.Size(677, 145);
            this.dragDropInput.TabIndex = 1;
            this.dragDropInput.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropInput_DragDrop);
            this.dragDropInput.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDropInput_DragEnter);
            this.dragDropInput.DragLeave += new System.EventHandler(this.dragDropInput_DragLeave);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Transparent;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Image = global::DigitalSignature.Properties.Resources._39;
            this.removeButton.Location = new System.Drawing.Point(609, 46);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(55, 50);
            this.removeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removeButton.TabIndex = 2;
            this.removeButton.TabStop = false;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // uplodedDocument
            // 
            this.uplodedDocument.Controls.Add(this.documentIconPicture);
            this.uplodedDocument.Controls.Add(this.documentPath);
            this.uplodedDocument.Controls.Add(this.documentTitle);
            this.uplodedDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uplodedDocument.Location = new System.Drawing.Point(16, 7);
            this.uplodedDocument.Name = "uplodedDocument";
            this.uplodedDocument.Size = new System.Drawing.Size(555, 130);
            this.uplodedDocument.TabIndex = 5;
            this.uplodedDocument.TabStop = false;
            this.uplodedDocument.Text = "Uploded Document";
            this.uplodedDocument.Visible = false;
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
            // dragDropLabel
            // 
            this.dragDropLabel.AllowDrop = true;
            this.dragDropLabel.AutoSize = true;
            this.dragDropLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dragDropLabel.Location = new System.Drawing.Point(178, 55);
            this.dragDropLabel.Name = "dragDropLabel";
            this.dragDropLabel.Size = new System.Drawing.Size(289, 32);
            this.dragDropLabel.TabIndex = 0;
            this.dragDropLabel.Text = "Drop file in this area";
            // 
            // documentContentTextBox
            // 
            this.documentContentTextBox.Location = new System.Drawing.Point(35, 233);
            this.documentContentTextBox.Multiline = true;
            this.documentContentTextBox.Name = "documentContentTextBox";
            this.documentContentTextBox.ReadOnly = true;
            this.documentContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.documentContentTextBox.Size = new System.Drawing.Size(677, 141);
            this.documentContentTextBox.TabIndex = 2;
            this.documentContentTextBox.Visible = false;
            // 
            // signDocumentButton
            // 
            this.signDocumentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signDocumentButton.Image = global::DigitalSignature.Properties.Resources.signature_pen_document_text_512;
            this.signDocumentButton.Location = new System.Drawing.Point(644, 380);
            this.signDocumentButton.Name = "signDocumentButton";
            this.signDocumentButton.Size = new System.Drawing.Size(68, 50);
            this.signDocumentButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signDocumentButton.TabIndex = 3;
            this.signDocumentButton.TabStop = false;
            this.signDocumentButton.Visible = false;
            this.signDocumentButton.Click += new System.EventHandler(this.signDocumentButton_Click);
            // 
            // documentContentLable
            // 
            this.documentContentLable.AutoSize = true;
            this.documentContentLable.Location = new System.Drawing.Point(35, 210);
            this.documentContentLable.Name = "documentContentLable";
            this.documentContentLable.Size = new System.Drawing.Size(123, 17);
            this.documentContentLable.TabIndex = 4;
            this.documentContentLable.Text = "Document content";
            this.documentContentLable.Visible = false;
            // 
            // SignDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 456);
            this.ControlBox = false;
            this.Controls.Add(this.documentContentLable);
            this.Controls.Add(this.signDocumentButton);
            this.Controls.Add(this.documentContentTextBox);
            this.Controls.Add(this.dragDropInput);
            this.Name = "SignDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignDocumentForm";
            this.dragDropInput.ResumeLayout(false);
            this.dragDropInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).EndInit();
            this.uplodedDocument.ResumeLayout(false);
            this.uplodedDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentIconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signDocumentButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel dragDropInput;
        private System.Windows.Forms.Label dragDropLabel;
        private System.Windows.Forms.PictureBox removeButton;
        private System.Windows.Forms.PictureBox documentIconPicture;
        private System.Windows.Forms.Label documentTitle;
        private System.Windows.Forms.Label documentPath;
        private System.Windows.Forms.GroupBox uplodedDocument;
        private System.Windows.Forms.TextBox documentContentTextBox;
        private System.Windows.Forms.PictureBox signDocumentButton;
        private System.Windows.Forms.Label documentContentLable;
    }
}