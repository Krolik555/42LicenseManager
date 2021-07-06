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
        public ConfigClass ConfigOutput = new ConfigClass();
        public ConfigClass _configInput = new ConfigClass();

        public bool? Preload_AllowDupeClients { get; set; }
        public bool? Preload_AllowDupeMachines { get; set; }

        public ConfigForm()
        {
            InitializeComponent();
            wireup();
        }

        public ConfigForm(ConfigClass ConfigInput)
        {
            _configInput = ConfigInput;
            Preload_AllowDupeClients = _configInput.AllowDuplicateClients;
            Preload_AllowDupeMachines = _configInput.AllowDuplicateMachines;
            InitializeComponent();
            wireup();
        }



        public void wireup()
        {
            // Review Checkboxes. If checked, disable them first to prevent warning message
            if (Preload_AllowDupeMachines == true)
            {
                aCheckBoxAllowDupeMachines.Enabled = false;
                aCheckBoxAllowDupeMachines.Checked = Preload_AllowDupeMachines.Value;
            }
            if (Preload_AllowDupeClients == true)
            {
                aCheckBoxAllowDupeClients.Enabled = false;
                aCheckBoxAllowDupeClients.Checked = Preload_AllowDupeClients.Value;
            }




            // If data exists, fill fields
            if (Class_Library.Settings.SelectedDatabaseConfigFilePath != null)
            {
                //MessageBox.Show(Class_Library.Settings.SelectedDatabaseConfigFilePath);

                aTextBoxDir.Text = _configInput.DBDir_Name;
                aTextBoxTimeToRenew.Text = _configInput.TimeToRenew;
                aCheckBoxAllowDupeClients.Checked = _configInput.AllowDuplicateClients;
                aCheckBoxAllowDupeMachines.Checked = _configInput.AllowDuplicateMachines;
            }

        }

        private void AButtonBrowse_Click(object sender, EventArgs e)
        {
            var BrowseFile = new OpenFileDialog();
            BrowseFile.Filter = "Database Files (*.mdf) | *.mdf";
            if (BrowseFile.ShowDialog() == DialogResult.OK)
            {
                aTextBoxDir.Text = BrowseFile.FileName;
                checkConfig(Path.GetDirectoryName(aTextBoxDir.Text) + @"\Config.txt");
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
                NewConfig.AllowDuplicateClients = aCheckBoxAllowDupeClients.Checked;
                NewConfig.AllowDuplicateMachines = aCheckBoxAllowDupeMachines.Checked;

                Class_Library.Config.Update(NewConfig);
                ConfigOutput = NewConfig;

                // Add new db to DatabaseLibrary
                Class_Library.DatabaseLibrary.Add(NewConfig.DBDir_Name);

            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void AButtonCreateNewDatabase_Click(object sender, EventArgs e)
        {
            CreateDatabaseForm CreateNewDBForm = new CreateDatabaseForm();
            DialogResult _CreateDBForm = CreateNewDBForm.ShowDialog();
            if (_CreateDBForm == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void ATextBoxDir_Leave(object sender, EventArgs e)
        {
            if (aTextBoxDir.Text.EndsWith(".mdf"))
            {
                string configPath = Path.GetDirectoryName(aTextBoxDir.Text) + @"\Config.txt";

                if (File.Exists(configPath))
                {
                    // Get config and fill fields
                    checkConfig(configPath);                   
                }

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



        #region Methods
        public void checkConfig(string ConfigFileDir)
        {
            try
            {
                // CHECK FOR CONFIG
                if (File.Exists(ConfigFileDir))
                {
                    ConfigClass ConfigData = Class_Library.Config.Get(ConfigFileDir);


                    aTextBoxTimeToRenew.Text = ConfigData.TimeToRenew;
                    if (ConfigData.AllowDuplicateMachines)
                    {
                        aCheckBoxAllowDupeMachines.Enabled = false;
                        aCheckBoxAllowDupeMachines.Checked = true;
                    }
                    
                }
                else
                {
                    // Leave blank to make user select values
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
        #endregion


    }
}
