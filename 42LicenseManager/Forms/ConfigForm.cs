using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    public partial class ConfigForm : Form
    {
        ConfigClass ConfigOutput = new ConfigClass();

        public ConfigForm()
        {
            InitializeComponent();
            wireup();
        }
        public void wireup()
        {
            try
            {
                // CHECK FOR CONFIG
                if (File.Exists($@"{Environment.CurrentDirectory}\Config.txt"))
                {
                    ConfigClass ConfigData = Class_Library.Config.Get();

                    aTextBoxDir.Text = ConfigData.DBDir_Name;
                    aTextBoxTimeToRenew.Text = ConfigData.TimeToRenew;
                    aCheckBoxAllowDupeMachines.Checked = ConfigData.AllowDuplicateMachines;
                }
                else
                {
                    // INSERT DEFAULT VALUES INTO TEXT BOXES
                    aTextBoxDir.Text = $@"C:\Users\{Environment.UserName}\Documents\42LicenseManager\42LMDB.mdf";
                    aTextBoxTimeToRenew.Text = 21.ToString();
                    aCheckBoxAllowDupeMachines.Checked = true;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }

            // If "allow duplicates" is checked, disable the checkbox.
            if (aCheckBoxAllowDupeMachines.Checked)
            {
                aCheckBoxAllowDupeMachines.Enabled = false;
                aLabelAllowDupeMachineDisabledTip.Visible = true;
            }

        }

        private void AButtonBrowse_Click(object sender, EventArgs e)
        {
            var BrowseFile = new OpenFileDialog();
            BrowseFile.Filter = "Database Files (*.mdf) | *.mdf";
            if (BrowseFile.ShowDialog() == DialogResult.OK)
            {
                aTextBoxDir.Text = BrowseFile.FileName;
            }

        }

        private void aButtonSave_Click(object sender, EventArgs e)
        {
            ConfigClass NewConfig = new ConfigClass();
            try
            {
                // SAVE DATA TO CONFIG OBJECT
                NewConfig.DBDir_Name = aTextBoxDir.Text;
                NewConfig.TimeToRenew = aTextBoxTimeToRenew.Text;
                NewConfig.InstalledDirectory = Environment.CurrentDirectory;
                NewConfig.AllowDuplicateMachines = aCheckBoxAllowDupeMachines.Checked;

                Class_Library.Config.Update(NewConfig);


            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            this.Close();
        }

        private void AButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public ConfigClass OutputConfig()
        {
            return ConfigOutput;
        }

        private void AButtonCreateNewDatabase_Click(object sender, EventArgs e)
        {
            CreateDatabaseForm CreateNewDBForm = new CreateDatabaseForm();
            DialogResult _CreateDBForm = CreateNewDBForm.ShowDialog();
            if (_CreateDBForm == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void ATextBoxDir_Leave(object sender, EventArgs e)
        {

        }

        private void aCheckBoxAllowDupeMachines_CheckStateChanged(object sender, EventArgs e)
        {
            if (aCheckBoxAllowDupeMachines.Checked)
            {
                MessageBox.Show("Once this has been checked it cannot be unchecked. Is this okay?", "Warning!", MessageBoxButtons.OKCancel);
            }
        }
    }
}
