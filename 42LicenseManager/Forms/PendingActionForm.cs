using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace _42LicenseManager.Forms
{
    public partial class PendingActionForm : Form
    {
        //public string _message { get; set; }
        //public string _animatedString { get; set; }


        /// <summary>
        /// Message cannot exceed 104 characters. Anything greater will not be displayed.
        /// </summary>
        public PendingActionForm(string message, string animatedString)
        {
            InitializeComponent();

            aLabelAnimation.Text = animatedString;
            
        }


    }
}
