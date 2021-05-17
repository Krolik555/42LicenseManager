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
    public partial class BackupForm : Form
    {
        public ConfigClass config = new ConfigClass();

        public BackupForm()
        {
            InitializeComponent();

            #region Set values from config
            // Get saved config data
            config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);

            // Set values on startup
            aTextboxBackupTarget.Text = config.BackupTarget_PathOnly;
            aCheckBoxAutoBackup.Checked = config.AutoBackup;
            aGroupBackup.Enabled = aCheckBoxAutoBackup.Checked;

            // Find saved config value in combobox.items and select that item.
            aComboboxBackupSchedule.SelectedIndex = aComboboxBackupSchedule.FindStringExact(config.BackupSchedule.ToString());
            aComboboxBackupExpiration.SelectedIndex = aComboboxBackupExpiration.FindStringExact(config.BackupExpiration.ToString());
            #endregion

        }

        private void aButtonBrowse_Click(object sender, EventArgs e)
        {
            // Browse for folder
            FolderBrowserDialog BrowseFolder = new FolderBrowserDialog();
            if (BrowseFolder.ShowDialog() == DialogResult.OK)
            {
                aTextboxBackupTarget.Text = BrowseFolder.SelectedPath;
            }
        }

        private void aButtonSave_Click(object sender, EventArgs e)
        {
            if (aCheckBoxAutoBackup.Checked && aTextboxBackupTarget.Text == "")
            {
                MessageBox.Show("You cannot run auto backups without a backup destination.");
            }
            else
            {
                // gather config data from fields
                config.BackupTarget_PathOnly = aTextboxBackupTarget.Text;
                config.AutoBackup = aCheckBoxAutoBackup.Checked;
                config.BackupSchedule = Convert.ToInt32(aComboboxBackupSchedule.SelectedItem);
                config.BackupExpiration = Convert.ToInt32(aComboboxBackupExpiration.SelectedItem);

                // update config file
                Class_Library.Config.Update(config);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void aCheckBoxAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            aGroupBackup.Enabled = aCheckBoxAutoBackup.Checked;
        }

        private void aButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
