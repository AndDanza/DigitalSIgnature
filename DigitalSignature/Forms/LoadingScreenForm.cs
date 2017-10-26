using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSignature.Forms
{
    public partial class LoadingScreenForm : Form
    {
        Timer progressBarTimer;
        string fileName;
        string operationName;

        public LoadingScreenForm(string name, string operation)
        {
            InitializeComponent();
            fileName = name;
            operationName = operation;
            progressBarTimer = new Timer();
        }

        private void LoadingScreenForm_Load(object sender, EventArgs e)
        {
            progressBarTimer.Enabled = true;
            progressBarTimer.Start();
            progressBarTimer.Interval = 500;
            progressBar1.Maximum = 10;
            progressBarTimer.Tick += new EventHandler(IncreaseProgress);

            ShowFileName();
        }

        private void ShowFileName()
        {
            showNameLabel.Text = fileName;
            showOperationLabel.Text = operationName;
        }

        private void IncreaseProgress(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                progressBarTimer.Stop();
                this.Dispose();
            }
        }
    }
}
