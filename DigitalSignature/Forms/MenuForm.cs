using DigitalSignature.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void signOptionPicture_Click(object sender, EventArgs e)
        {
            CloseActiveForm();
            OpenSignDocumentForm();
        }
        
        private void signLabel_Click(object sender, EventArgs e)
        {
            CloseActiveForm();
            OpenSignDocumentForm();
        }

        private void CloseActiveForm()
        {
            this.Close();
        }

        private void OpenSignDocumentForm()
        {
            MainForm mainForm = (MainForm) Application.OpenForms[0];

            UploadDocumentForm signForm = new UploadDocumentForm();
            signForm.TopLevel = false;
            signForm.ControlBox = false;
            signForm.Dock = DockStyle.Fill;
            signForm.FormBorderStyle = FormBorderStyle.None;
            mainForm.Controls.Add(signForm);
            signForm.Show();
        }
    }
}
