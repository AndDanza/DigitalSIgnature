namespace DigitalSignature.Forms
{
    partial class LoadingScreenForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.operationLabel = new System.Windows.Forms.Label();
            this.showNameLabel = new System.Windows.Forms.Label();
            this.showOperationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 101);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(324, 43);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 1;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameLabel.Location = new System.Drawing.Point(35, 24);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(51, 24);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "File:";
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationLabel.Location = new System.Drawing.Point(35, 56);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(108, 24);
            this.operationLabel.TabIndex = 2;
            this.operationLabel.Text = "Operation:";
            // 
            // showNameLabel
            // 
            this.showNameLabel.AutoSize = true;
            this.showNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNameLabel.Location = new System.Drawing.Point(101, 24);
            this.showNameLabel.Name = "showNameLabel";
            this.showNameLabel.Size = new System.Drawing.Size(60, 24);
            this.showNameLabel.TabIndex = 3;
            this.showNameLabel.Text = "label3";
            // 
            // showOperationLabel
            // 
            this.showOperationLabel.AutoSize = true;
            this.showOperationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOperationLabel.Location = new System.Drawing.Point(149, 56);
            this.showOperationLabel.Name = "showOperationLabel";
            this.showOperationLabel.Size = new System.Drawing.Size(60, 24);
            this.showOperationLabel.TabIndex = 4;
            this.showOperationLabel.Text = "label4";
            // 
            // LoadingScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 173);
            this.ControlBox = false;
            this.Controls.Add(this.showOperationLabel);
            this.Controls.Add(this.showNameLabel);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.progressBar1);
            this.Name = "LoadingScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LoadingScreenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Label showNameLabel;
        private System.Windows.Forms.Label showOperationLabel;
    }
}