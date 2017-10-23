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
            this.dragDropLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.docuemntTitle = new System.Windows.Forms.Label();
            this.documentPath = new System.Windows.Forms.Label();
            this.uplodedDocument = new System.Windows.Forms.GroupBox();
            this.dragDropInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uplodedDocument.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragDropInput
            // 
            this.dragDropInput.AllowDrop = true;
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
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Transparent;
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.Image = global::DigitalSignature.Properties.Resources._39;
            this.removeButton.Location = new System.Drawing.Point(685, 23);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(55, 50);
            this.removeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.removeButton.TabIndex = 2;
            this.removeButton.TabStop = false;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DigitalSignature.Properties.Resources._12_File_512;
            this.pictureBox1.Location = new System.Drawing.Point(14, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // docuemntTitle
            // 
            this.docuemntTitle.AutoSize = true;
            this.docuemntTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docuemntTitle.Location = new System.Drawing.Point(115, 40);
            this.docuemntTitle.Name = "docuemntTitle";
            this.docuemntTitle.Size = new System.Drawing.Size(53, 20);
            this.docuemntTitle.TabIndex = 3;
            this.docuemntTitle.Text = "label1";
            // 
            // documentPath
            // 
            this.documentPath.AutoSize = true;
            this.documentPath.Location = new System.Drawing.Point(116, 72);
            this.documentPath.Name = "documentPath";
            this.documentPath.Size = new System.Drawing.Size(46, 17);
            this.documentPath.TabIndex = 4;
            this.documentPath.Text = "label1";
            // 
            // uplodedDocument
            // 
            this.uplodedDocument.Controls.Add(this.pictureBox1);
            this.uplodedDocument.Controls.Add(this.documentPath);
            this.uplodedDocument.Controls.Add(this.docuemntTitle);
            this.uplodedDocument.Location = new System.Drawing.Point(16, 7);
            this.uplodedDocument.Name = "uplodedDocument";
            this.uplodedDocument.Size = new System.Drawing.Size(374, 130);
            this.uplodedDocument.TabIndex = 5;
            this.uplodedDocument.TabStop = false;
            this.uplodedDocument.Text = "Uploded Document";
            this.uplodedDocument.Visible = false;
            // 
            // SignDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 456);
            this.ControlBox = false;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.dragDropInput);
            this.Name = "SignDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SignDocumentForm";
            this.dragDropInput.ResumeLayout(false);
            this.dragDropInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uplodedDocument.ResumeLayout(false);
            this.uplodedDocument.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dragDropInput;
        private System.Windows.Forms.Label dragDropLabel;
        private System.Windows.Forms.PictureBox removeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label docuemntTitle;
        private System.Windows.Forms.Label documentPath;
        private System.Windows.Forms.GroupBox uplodedDocument;
    }
}