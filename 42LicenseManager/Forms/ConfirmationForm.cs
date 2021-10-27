using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager.Forms
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm(string Message)
        {
            InitializeComponent();
            aTextBoxMsg.Text = Message;
        }

        private void aTextBoxOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
