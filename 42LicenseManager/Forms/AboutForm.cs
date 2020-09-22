using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            aTextBoxInfo.Text = "42Transfer was designed and coded by Nathan Ebersole." +
                "\nStarted January 5th, 2018" +
                "\nCompleted June 8th, 2018 - (v1.5)" +
                "\nBeen squashing bugs and improving it ever since." +
                $"\nCurrent Version: {System.Reflection.Assembly.GetEntryAssembly().GetName().Version}";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
