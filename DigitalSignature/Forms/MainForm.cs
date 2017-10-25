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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            //trebat će kasnije
            //MainForm mainForm = (MainForm)Application.OpenForms[0];

            UploadDocumentForm signForm = new UploadDocumentForm();
            signForm.TopLevel = false;
            signForm.ControlBox = false;
            signForm.Dock = DockStyle.Fill;
            signForm.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(signForm);
            signForm.Show();
        }
    }
}
