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
        private Timer countToOpen;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowWorkForm(object sender, EventArgs e)
        {
            countToOpen.Stop();
            headlineLabel.Dispose();
            pictureBox1.Dispose();

            UploadDocumentForm signForm = new UploadDocumentForm();
            signForm.TopLevel = false;
            signForm.ControlBox = false;
            signForm.Dock = DockStyle.Fill;
            signForm.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(signForm);
            signForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            countToOpen = new Timer();
            countToOpen.Enabled = true;
            countToOpen.Interval = 3900;
            countToOpen.Tick += new EventHandler(ShowWorkForm);
            countToOpen.Start();
        }
    }
}
