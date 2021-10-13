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
    public partial class AddMachinesForm : Form
    {
        // License that is currently being modified.
        public License InputLicense { get; set; }
        // New machine added
        public LicensedMachines NewMachine { get; set; }
        // Database info
        ConfigClass Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);

        public AddMachinesForm()
        {
            InitializeComponent();
        }

        private void aButtonSave_Click(object sender, EventArgs e)
        {
            // VERIFY MACHINE DOESN'T EXIST ELSWHERE
            if (Utilities.MachineExists(aTextBoxMachineName.Text, Config.DBDir_Name, out List<int> LicenseIDofDupes) && Config.AllowDuplicateMachines == false)
            {
                // !ERROR!
                MessageBox.Show($"This machine name is already being used by License {LicenseIDofDupes[0].ToString()}. " +
                    $"\nNo duplicates are allowed at this time. Please rename the machine and try again.", "Duplicate!", MessageBoxButtons.OK);
                return;
            }
            else
            {
                //LicensedMachines NewMachine = new LicensedMachines();
                NewMachine = new LicensedMachines();

                // IF DATE INSTALLED IS ENABLED GET DATE
                NewMachine.InstallDate = aDateTimePickerInstalled.Enabled ? aDateTimePickerInstalled.Value.ToShortDateString() : null;

                // GET THE REST OF THE DATA
                NewMachine.MachineName = aTextBoxMachineName.Text;
                NewMachine.MachineNotes = aTextBoxNotes.Text;
                NewMachine.LicenseId = InputLicense.Id;

                // Add to DATABASE
                DataAccess_LicensedMachinesTable.AddLicensedMachines(NewMachine, Config.DBDir_Name);


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void aButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ACheckBoxUseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (aCheckBoxUseDate.Checked)
            {
                aDateTimePickerInstalled.Enabled = true;
            }
            else
            {
                aDateTimePickerInstalled.Enabled = false;
            }
        }

        private void aTextBoxMachineName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                aButtonSave_Click(sender, e);
            }
        }

        private void aDateTimePickerInstalled_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                aButtonSave_Click(sender, e);
            }
        }

        private void aCheckBoxUseDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                aButtonSave_Click(sender, e);
            }
        }
    }
}
