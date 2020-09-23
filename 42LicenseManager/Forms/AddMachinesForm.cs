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
        public int LicenseID { get; set; }
        ConfigClass Config = Class_Library.Config.Get();

        public AddMachinesForm()
        {
            InitializeComponent();
        }

        private void aButtonSave_Click(object sender, EventArgs e)
        {
            // VERIFY MACHINE DOESN'T EXIST ELSWHERE
            if (Utilities.MachineExist(aTextBoxMachineName.Text, Config.DBDir_Name, out List<int> LicenseIDofDupes) && Config.AllowDuplicateMachines == false)
            {
                // !ERROR!
                MessageBox.Show($"This machine name is already being used by License {LicenseIDofDupes[0].ToString()}. " +
                    $"\nNo duplicates are allowed at this time. Please rename the machine and try again.", "Duplicate!", MessageBoxButtons.OK);
                return;
            }
            else
            {
                LicensedMachines NewMachine = new LicensedMachines();

                // IF DATE INSTALLED IS ENABLED GET DATE
                NewMachine.InstallDate = aDateTimePickerInstalled.Enabled ? aDateTimePickerInstalled.Value.ToShortDateString() : null;

                // GET THE REST OF THE DATA
                NewMachine.MachineName = aTextBoxMachineName.Text;
                NewMachine.MachineNotes = aTextBoxNotes.Text;
                NewMachine.LicenseId = LicenseID;

                // UPDATE DATABASE
                DataAccess_LicensedMachinesTable.AddLicensedMachines(NewMachine, Config.DBDir_Name);

                // CREATE NEW MACHINE LOG
                LogClass NewLog = new LogClass();
                NewLog.LicenseId = LicenseID; // Identify which account had the changes.
                DateTime dt = DateTime.Now; // Get current date/time
                NewLog.Date = dt;
                NewLog.Log = $"New Machine added: '{NewMachine.MachineName}'";

                // SAVE NEW MACHINE LOG TO LOG DATABASE
                DataAccess_ChangeLogTable.CreateNewLog(NewLog, Config.DBDir_Name);
                Utilities.CloseSQLConnection();
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
    }
}
