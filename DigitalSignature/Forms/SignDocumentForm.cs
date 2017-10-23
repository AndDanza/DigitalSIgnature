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
    public partial class SignDocumentForm : Form
    {
        public SignDocumentForm()
        {
            InitializeComponent();
        }

        private void dragDropInput_DragDrop(object sender, DragEventArgs e)
        {
            dragDropLabel.Hide();
            removeButton.Visible = true;
            dragDropInput.AllowDrop = false;
            dragDropInput.BackColor = SystemColors.Control;
            dragDropInput.BorderStyle = BorderStyle.Fixed3D;
            uplodedDocument.Visible = true;
        }

        private void dragDropInput_DragEnter(object sender, DragEventArgs e)
        {
            dragDropInput.BackColor = Color.LightGreen;
            e.Effect = DragDropEffects.All;
        }

        private void dragDropInput_DragLeave(object sender, EventArgs e)
        {
            dragDropInput.BackColor = SystemColors.Control;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            dragDropInput.BackColor = SystemColors.Control;
            dragDropLabel.Show();
            removeButton.Visible = false;
            dragDropInput.BorderStyle = BorderStyle.None;
            dragDropInput.AllowDrop = true;
            uplodedDocument.Visible = false;
        }
    }
}
