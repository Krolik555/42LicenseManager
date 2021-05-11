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
    public partial class EditLicensedMachineForm : Form
    {
        public LicensedMachines InputMachine { get; set; }
        LicensedMachines ChangedLicense = new LicensedMachines();
        ConfigClass Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);

        public EditLicensedMachineForm()
        {
            InitializeComponent();
        }

        private void EditLicensedMachineForm_Shown(object sender, EventArgs e)
        {
            // Fill data fields from InputLicense
            if (InputMachine.InstallDate != null && InputMachine.InstallDate != "")
            {
                aDateTimePickerInstalled.Value = DateTime.Parse(InputMachine.InstallDate);
            }
            else
            {
                aDateTimePickerInstalled.Value = DateTime.Now;
                aCheckBoxUseDate.Checked = false;
            }
            aTextBoxMachineName.Text = InputMachine.MachineName;
            aTextBoxNotes.Text = InputMachine.MachineNotes;
        }

        private void aButtonSave_Click(object sender, EventArgs e)
        {
            // Check if machine exists and if duplicates are allowed
            if (Utilities.MachineExist(InputMachine, aTextBoxMachineName.Text, Config.DBDir_Name, out List<int> LicenseIDofDupes) && Config.AllowDuplicateMachines == false)
            {
                // !ERROR!
                MessageBox.Show($"This machine name is already being used by License {LicenseIDofDupes[0].ToString()}. " +
                    $"\nNo duplicates are allowed at this time. Please rename the machine and try again.", "Duplicate!", MessageBoxButtons.OK);
                return;
            }
            else // if no duplicate and/or duplicates are allowed - edit machine name
            {
                InputMachine.CopyDataTo(ChangedLicense); // Used to get the ID and LicenseID of the input license.

                if (ChangedLicense != InputMachine)
                {

                    // IF DATE INSTALLED IS ENABLED GET DATE
                    ChangedLicense.InstallDate = aDateTimePickerInstalled.Enabled ? aDateTimePickerInstalled.Value.ToShortDateString() : null;

                    // GET THE REST OF THE DATA
                    ChangedLicense.MachineName = aTextBoxMachineName.Text;
                    ChangedLicense.MachineNotes = aTextBoxNotes.Text;

                    // UPDATE DATABASE
                    DataAccess_LicensedMachinesTable.UpdateLicensedMachineData(ChangedLicense, Config.DBDir_Name);

                    // GET CHANGES MADE
                    List<string> changesmade = Utilities.FindChanges(InputMachine, ChangedLicense);

                    // CREATE CHANGES MADE LOG
                    Utilities.CreateLog(changesmade, InputMachine.LicenseId);
                    Utilities.CloseSQLConnection();
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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
    }
}
