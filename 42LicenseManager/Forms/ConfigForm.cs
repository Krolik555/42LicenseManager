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
                    //// READ CONFIG
                    string[] contents = File.ReadAllLines($@"{Environment.CurrentDirectory}\Config.txt");
                    if (contents != null && contents.Length >= 0)
                    { // DISPLAY DATA IN TEXT BOXES
                        aTextBoxDir.Text = contents[0].Remove(0, 6); // Remove "DBDIR="
                        aTextBoxTimeToRenew.Text = contents[1].Remove(0, 12); // Remove "TimeToRenew="
                    }
                }
                else
                {
                    // INSERT DEFAULT VALUES INTO TEXT BOXES
                    aTextBoxDir.Text = $@"C:\Users\{Environment.UserName}\Documents\42LicenseManager\42LMDB.mdf";
                    aTextBoxTimeToRenew.Text = 21.ToString();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
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
            try
            {
                // SAVE DATA TO CONFIG OBJECT
                ConfigOutput.DBDir_Name = aTextBoxDir.Text;
                ConfigOutput.TimeToRenew = aTextBoxTimeToRenew.Text;
                ConfigOutput.InstalledDirectory = Environment.CurrentDirectory;

                // VERIFY DATABASE EXISTS BEFORE CLOSING
                if (Utilities.VerifyDatabaseExists(ConfigOutput))
                {
                    // OVERWRITE/CREATE CONFIG FILE USING TEXT BOX DATA
                    TextWriter tw = new StreamWriter($@"{Environment.CurrentDirectory}\Config.txt");
                    tw.WriteLine($"DBDIR={aTextBoxDir.Text}");
                    tw.WriteLine($"TimeToRenew={aTextBoxTimeToRenew.Text}");
                    tw.WriteLine($"InstalledDirectory={Environment.CurrentDirectory}");
                    tw.Close();

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The selected Database does not exist.");
                    aTextBoxDir.Select();
                }
                

            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
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
    }
}
