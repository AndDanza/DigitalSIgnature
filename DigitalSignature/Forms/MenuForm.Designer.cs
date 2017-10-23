﻿namespace DigitalSignature
{
    partial class MenuForm
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
            this.signLabel = new System.Windows.Forms.Label();
            this.validateLabel = new System.Windows.Forms.Label();
            this.validateOptionPicture = new System.Windows.Forms.PictureBox();
            this.signOptionPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.validateOptionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOptionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // signLabel
            // 
            this.signLabel.AutoSize = true;
            this.signLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signLabel.Location = new System.Drawing.Point(145, 330);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(190, 29);
            this.signLabel.TabIndex = 2;
            this.signLabel.Text = "Sign Document";
            // 
            // validateLabel
            // 
            this.validateLabel.AutoSize = true;
            this.validateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateLabel.Location = new System.Drawing.Point(385, 330);
            this.validateLabel.Name = "validateLabel";
            this.validateLabel.Size = new System.Drawing.Size(232, 29);
            this.validateLabel.TabIndex = 3;
            this.validateLabel.Text = "Validate Document";
            // 
            // validateOptionPicture
            // 
            this.validateOptionPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validateOptionPicture.Image = global::DigitalSignature.Properties.Resources.validate;
            this.validateOptionPicture.Location = new System.Drawing.Point(409, 161);
            this.validateOptionPicture.Name = "validateOptionPicture";
            this.validateOptionPicture.Size = new System.Drawing.Size(185, 145);
            this.validateOptionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.validateOptionPicture.TabIndex = 5;
            this.validateOptionPicture.TabStop = false;
            // 
            // signOptionPicture
            // 
            this.signOptionPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOptionPicture.Image = global::DigitalSignature.Properties.Resources.sign;
            this.signOptionPicture.Location = new System.Drawing.Point(150, 161);
            this.signOptionPicture.Name = "signOptionPicture";
            this.signOptionPicture.Size = new System.Drawing.Size(185, 145);
            this.signOptionPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signOptionPicture.TabIndex = 4;
            this.signOptionPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digital Signature";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 456);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validateOptionPicture);
            this.Controls.Add(this.signOptionPicture);
            this.Controls.Add(this.validateLabel);
            this.Controls.Add(this.signLabel);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.validateOptionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOptionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.Label validateLabel;
        private System.Windows.Forms.PictureBox signOptionPicture;
        private System.Windows.Forms.PictureBox validateOptionPicture;
        private System.Windows.Forms.Label label1;
    }
}