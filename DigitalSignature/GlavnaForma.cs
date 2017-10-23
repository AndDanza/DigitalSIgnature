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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            MenuForm startingForm = new MenuForm();
            startingForm.TopLevel = false;
            startingForm.ControlBox = false;
            startingForm.Dock = DockStyle.Fill;
            startingForm.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(startingForm);
            startingForm.Show();
        }
    }
}
