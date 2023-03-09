using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager.Class_Library
{
    public static class gAddMachine
    {

        /// <summary>
        /// Adds a single machine name to a license. 
        /// InstallDateKnown and InstallDate parameters are optional.
        /// </summary>
        /// <param name="MachineName"></param>
        /// <param name="MachineNotes"></param>
        /// <param name="InputLicenseID"></param>
        /// <param name="InstallDateKnown"></param>
        /// <param name="InstallDate"></param>
        public static void Add(string MachineName, string MachineNotes, int InputLicenseID, bool InstallDateKnown = false, DateTimePicker InstallDate = null)
        {
            LicensedMachines NewMachine = new LicensedMachines();
            // VERIFY MACHINE DOESN'T EXIST ELSWHERE if duplicates are not allowed.
            if (Utilities.MachineExists(MachineName, Settings.gConfig.DBDir_Name, out List<int> LicenseIDofDupes) && Settings.gConfig.AllowDuplicateMachines == false)
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
                NewMachine.InstallDate = InstallDateKnown ? InstallDate.Value.ToShortDateString() : null;

                // GET THE REST OF THE DATA
                NewMachine.MachineName = MachineName;
                NewMachine.MachineNotes = MachineNotes;
                NewMachine.LicenseId = InputLicenseID;

                // Add to DATABASE
                DataAccess_LicensedMachinesTable.AddLicensedMachines(NewMachine, Settings.gConfig.DBDir_Name);

            }
        }
    }
}
