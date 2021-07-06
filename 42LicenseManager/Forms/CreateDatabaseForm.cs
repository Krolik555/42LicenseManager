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
    public partial class CreateDatabaseForm : Form
    {
        //ConfigClass ConfigOutput = new ConfigClass();

        public CreateDatabaseForm()
        {
            InitializeComponent();
            aTextBoxNewDBDir.Text = $@"C:\42LicenseManagerDB";
            aTextBoxDatabaseName.Text = "MyDatabase";
            aTextBoxTimeToRenew.Text = "21";
        }

        private void AButtonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BrowseFolder = new FolderBrowserDialog();
            if (BrowseFolder.ShowDialog() == DialogResult.OK)
            {
                aTextBoxNewDBDir.Text = BrowseFolder.SelectedPath;
            }
        }

        private void AButtonCreateNewDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                string newdbdir = $@"{aTextBoxNewDBDir.Text}\{aTextBoxDatabaseName.Text}.mdf";
                if (File.Exists($@"{aTextBoxNewDBDir.Text}\{aTextBoxDatabaseName.Text}.mdf"))
                {
                    throw new System.IO.IOException();
                }

                Class_Library.DatabaseLibrary.Add(newdbdir);

                //// CREATE CONFIG FILE FOR NEW DATABASE
                //TextWriter tw = new StreamWriter($@"{aTextBoxNewDBDir.Text}\Config.txt", true);
                //tw.WriteLine($@"DBDIR={aTextBoxNewDBDir.Text}\{aTextBoxDatabaseName.Text}.mdf");
                //tw.WriteLine($"TimeToRenew={aTextBoxTimeToRenew.Text}");
                //tw.WriteLine($"InstalledDirectory={Environment.CurrentDirectory}");
                //tw.WriteLine($"AllowDuplicateMachines={aCheckBoxAllowDupeMachines.Checked}");
                //tw.WriteLine($"BackupTarget=");
                //tw.WriteLine($"AutoBackup=");
                //tw.WriteLine($"BackupSchedule=");
                //tw.WriteLine($"BackupExpiration=");
                //tw.Close();

                ConfigClass newConfig = new ConfigClass();
                newConfig.DBDir_Name = $@"{aTextBoxNewDBDir.Text}\{aTextBoxDatabaseName.Text}.mdf";
                newConfig.TimeToRenew = $"{aTextBoxTimeToRenew.Text}";
                newConfig.InstalledDirectory = $"{Environment.CurrentDirectory}";
                newConfig.AllowDuplicateClients = aCheckBoxAllowDupeClients.Checked;
                newConfig.AllowDuplicateMachines = aCheckBoxAllowDupeMachines.Checked;
                newConfig.BackupTarget_PathOnly = "";
                newConfig.AutoBackup = false;
                newConfig.BackupSchedule = 24;
                newConfig.BackupExpiration = 6;


                // CREATE NEW DATABASE
                Utilities.CreateNewDatabase(newConfig);
                // Create new Config file
                Class_Library.Config.Update(newConfig);

                

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("A database in this location already exists. \nTo create a new Database please use a database name that doesn't already exist.", "Already exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void ATextBoxNewDBDir_Leave(object sender, EventArgs e)
        {
            if (aTextBoxNewDBDir.Text.EndsWith(@"\"))
            {
                aTextBoxNewDBDir.Text = aTextBoxNewDBDir.Text.Remove(aTextBoxNewDBDir.Text.Length - 1);
                ATextBoxNewDBDir_Leave(this, e);
            }
            try
            {
                DirectoryInfo CheckDir = new DirectoryInfo(aTextBoxNewDBDir.Text);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void ATextBoxDatabaseName_Leave(object sender, EventArgs e)
        {
            if (aTextBoxDatabaseName.Text.EndsWith(".mdf"))
            {
                aTextBoxDatabaseName.Text = aTextBoxDatabaseName.Text.Remove(aTextBoxDatabaseName.Text.Length - 4);
            }
        }

        private void aCheckBoxAllowDupeClients_CheckStateChanged(object sender, EventArgs e)
        {
            if (aCheckBoxAllowDupeClients.Checked && aCheckBoxAllowDupeClients.Enabled)
            {
                if (MessageBox.Show("Once this has been checked it cannot be unchecked. Is this okay?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    aCheckBoxAllowDupeClients.Checked = false;
                }
            }
        }

        private void aCheckBoxAllowDupeMachines_CheckStateChanged(object sender, EventArgs e)
        {
            if (aCheckBoxAllowDupeMachines.Checked && aCheckBoxAllowDupeMachines.Enabled)
            {
                if (MessageBox.Show("Once this has been checked it cannot be unchecked. Is this okay?", "Warning!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    aCheckBoxAllowDupeMachines.Checked = false;
                }
            }
        }
    }
}
