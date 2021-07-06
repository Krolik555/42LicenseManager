using _42Transfer;
using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    class Utilities
    {
        public static void CloseSQLConnection()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    FileName = "cmd.exe",
                    Arguments = "/c sqllocaldb stop"
                }
            };
            p.Start();
        }

        public static string CorrectApostropheForSQL (string _StringToCorrect) // In SQL '' = '
        {
            string corrected = _StringToCorrect;

            try // FOR OTHER ERRORS
            {
                // DOWORK
                if (_StringToCorrect.Contains("'"))
                {
                    corrected = _StringToCorrect.Replace("'", "''");
                }
            }
            catch (NullReferenceException)
            {

            }
            catch (Exception e)
            {
                MessageBox.Show($"Error in text. Please correct and try again. {e.ToString()}");
            }
            return corrected;
        }

        public static void CreateLog(List<string> ChangesMade, int AccountIdentifier)
        {
            // GET DB DIRECTORY W/ DB NAME
            ConfigClass Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
            foreach (string change in ChangesMade)
            {
                // CREATE NEW LOG
                LogClass NewLog = new LogClass();
                NewLog.LicenseId = AccountIdentifier; // Identify which account had the changes.
                DateTime dt = DateTime.Now; // Get current date/time
                NewLog.Date = dt;
                NewLog.Log = change;
                // SAVE NEW LOG
                DataAccess_ChangeLogTable.CreateNewLog(NewLog, Config.DBDir_Name);
            }
        }


        /// <summary>
        /// Create a new database and config file.
        /// </summary>
        /// <param name="NewDBConfig"></param>
        /// <returns></returns>
        public static void CreateNewDatabase(ConfigClass NewDBConfig)
        {
            try
            {
                // GET FILE NAME OF DATABASE
                string DBFileName = Path.GetFileName(NewDBConfig.DBDir_Name);
                // GET DIRECTORY OF DATABASE
                string DBDirectory = NewDBConfig.DBDir_Name.Replace(DBFileName, "");
                // CREATE DIRECTORY FOR DATABASE
                Directory.CreateDirectory(DBDirectory);
                // CREATE DATABASE
                File.WriteAllBytes(NewDBConfig.DBDir_Name, Properties.Resources.GDataDatabase);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public static void EnableSearch(Button SearchButton, TextBox SearchTextbox, Label SearchLabel, bool Enable)
        {
            SearchLabel.Enabled = Enable;
            SearchTextbox.Enabled = Enable;
            SearchButton.Enabled = Enable;
        }


        /// <summary>
        /// Returns a string list of changes made to a License
        /// </summary>
        /// <param name="OriginalLicense"></param>
        /// <param name="ChangedLicense"></param>
        /// <returns></returns>
        public static List<string> FindChanges(License OriginalLicense, License ChangedLicense)
        {
            string Format = $"(License: {OriginalLicense.Id})";
            List<string> Changes = new List<string>();
            // COMPANY NAME
            if (OriginalLicense.CompanyName != ChangedLicense.CompanyName)
            {
                if (OriginalLicense.CompanyName == "")
                    Changes.Add($"{Format} Company Name info '{ChangedLicense.CompanyName}' added to {OriginalLicense.FirstName} {OriginalLicense.LastName}");
                else
                    Changes.Add($"{Format} Company Name '{OriginalLicense.CompanyName}' changed to '{ChangedLicense.CompanyName}'");
                
            }
            // FIRST NAME
            if (OriginalLicense.FirstName != ChangedLicense.FirstName)
            {
                if (OriginalLicense.FirstName == "")
                    Changes.Add($"{Format} First Name info '{ChangedLicense.FirstName}' added to {OriginalLicense.CompanyName}");
                else
                    Changes.Add($"{Format} First Name '{OriginalLicense.FirstName}' changed to '{ChangedLicense.FirstName}'");

            }
            // LAST NAME
            if (OriginalLicense.LastName != ChangedLicense.LastName)
            {
                if (OriginalLicense.LastName == "")
                    Changes.Add($"{Format} Last Name info '{ChangedLicense.LastName}' added to {OriginalLicense.CompanyName}");
                else
                    Changes.Add($"{Format} Last Name '{OriginalLicense.LastName}' changed to '{ChangedLicense.LastName}'");

            }
            // REVIEW STATUS
            if (OriginalLicense.ReviewStatus != ChangedLicense.ReviewStatus)
            {
                Changes.Add($"{Format} Review Status '{OriginalLicense.ReviewStatus}' changed to '{ChangedLicense.ReviewStatus}'");
            }
            // EXPIRATION DATE
            if (OriginalLicense.ExpirationDate != ChangedLicense.ExpirationDate)
            {
                Changes.Add($"{Format} Expiration Date '{OriginalLicense.ExpirationDate.ToShortDateString()}' changed to '{ChangedLicense.ExpirationDate.ToShortDateString()}'");
            }
            // ACTIVE
            if (OriginalLicense.Active != ChangedLicense.Active)
            {
                Changes.Add($"{Format} Active Status '{OriginalLicense.Active}' changed to '{ChangedLicense.Active}'");
            }
            // RENEWAL STATUS
            if (OriginalLicense.RenewalStatus != ChangedLicense.RenewalStatus)
            {
                Changes.Add($"{Format} Renewal Status '{OriginalLicense.RenewalStatus}' changed to '{ChangedLicense.RenewalStatus}'");
            }
            // NOTES
            if (OriginalLicense.Notes != ChangedLicense.Notes)
            {
                Changes.Add($"{Format} Notes changed.");
            }
            // CHKBOX WILL CANCEL
            if (OriginalLicense.ChkBxWillCancel != ChangedLicense.ChkBxWillCancel)
            {
                if (ChangedLicense.ChkBxWillCancel)
                {
                    Changes.Add($"{Format} 'Will Cancel' checked");
                }
                else
                {
                    Changes.Add($"{Format} 'Will Cancel' unchecked");
                }
            }
            // CHKBOX UNINSTALLED
            if (OriginalLicense.ChkBxUninstalled != ChangedLicense.ChkBxUninstalled)
            {
                if (ChangedLicense.ChkBxUninstalled)
                {
                    Changes.Add($"{Format} 'Uninstalled' checked");
                }
                else
                {
                    Changes.Add($"{Format} 'Uninstalled' unchecked");
                }
            }
            // CHKBOX DELETE
            if (OriginalLicense.ChkBxDeleted != ChangedLicense.ChkBxDeleted)
            {
                if (ChangedLicense.ChkBxDeleted)
                {
                    Changes.Add($"{Format} 'Deleted' checked");
                }
                else
                {
                    Changes.Add($"{Format} 'Delete' unchecked");
                }
            }
            return Changes;
        }


        /// <summary>
        /// Returns string list of changes made to a Licensed Machine
        /// </summary>
        /// <param name="OriginalMachine"></param>
        /// <param name="ChangedMachine"></param>
        /// <returns></returns>
        public static List<string> FindChanges (LicensedMachines OriginalMachine, LicensedMachines ChangedMachine)
        {
            string Format = $"(License: {OriginalMachine.LicenseId})";
            ConfigClass Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
            List<string> Changes = new List<string>();
            bool MachineNameChanged = false;
            // MACHINE NAME
            if (OriginalMachine.MachineName != ChangedMachine.MachineName)
            {
                Changes.Add($"{Format} Machine name changed from '{OriginalMachine.MachineName}' to '{ChangedMachine.MachineName}'");
                MachineNameChanged = true;
            }

            // DATE ADDED
            if (OriginalMachine.InstallDate != ChangedMachine.InstallDate)
            {
                if (MachineNameChanged)
                {
                    Changes.Add($"{Format} 'Install Date' for '{ChangedMachine.MachineName}' changed from '{OriginalMachine.InstallDate}' to '{ChangedMachine.InstallDate}'");
                }
                else
                {
                    Changes.Add($"{Format} 'Install Date' for '{OriginalMachine.MachineName}' changed from '{OriginalMachine.InstallDate}' to '{ChangedMachine.InstallDate}'");
                }
            }
            // MACHINE NOTES
            if (OriginalMachine.MachineNotes != ChangedMachine.MachineNotes)
            {
                if (MachineNameChanged)
                {
                    Changes.Add($"{Format} Machine's Notes changed for {ChangedMachine.MachineName}");
                }
                else
                {
                    Changes.Add($"{Format} Machine's Notes changed for {OriginalMachine.MachineName}");
                }
            }
            // LICENSE ID (If true, License has been moved to another account)
            if (OriginalMachine.LicenseId != ChangedMachine.LicenseId)
            {
                
                List<string> ChangesMadeFor_MovedTo_Account = new List<string>(); // Log details for the new License that the machine was moved to.
                if (MachineNameChanged)
                {
                    string Message = $"Moved PC '{ChangedMachine.MachineName}' from (License: {OriginalMachine.LicenseId}) to (License: {ChangedMachine.LicenseId}).";
                    Changes.Add(Message);
                    ChangesMadeFor_MovedTo_Account.Add(Message);
                    
                }
                else
                {
                    string Message = $"Moved PC '{OriginalMachine.MachineName}' from (License: {OriginalMachine.LicenseId}) to (License: {ChangedMachine.LicenseId}).";
                    Changes.Add(Message);
                    ChangesMadeFor_MovedTo_Account.Add(Message);
                }
                Utilities.CreateLog(ChangesMadeFor_MovedTo_Account, ChangedMachine.LicenseId);
            }
            return Changes;
        }


        ///// <summary>
        ///// Gets or creates program settings. If a Config file exists it will retrieve data from it otherwise it will create a new config file.
        ///// </summary>
        ///// <returns></returns>
        //public static ConfigClass GetConfigData()
        //{
        //    ConfigClass Config = new ConfigClass();
        //    string[] Conf = null;
        //    string ConfigFile = $@"{Environment.CurrentDirectory}\Config.txt";
        //    //string ConfigFile = $@"C:\Users\{Environment.UserName}\Appdata\Roaming\42LicenseManager\Config.txt";

        //    try
        //    {
        //        // IF CONFIG.TXT EXIST GET DATA
        //        //if (File.Exists($@"{Environment.CurrentDirectory}\Config.txt"))
        //        if (File.Exists(ConfigFile))
        //        {

        //            Conf = File.ReadAllLines(ConfigFile);
        //            if (Conf != null && Conf.Length >= 0)
        //            {
        //                try
        //                { // GET DATA IF VALID ELSE ERASE DATA
        //                    Config.DBDir_Name = Conf[0].Contains("DBDIR=") && Conf[0] != "" ? Conf[0].Remove(0, 6) : ""; // Remove "DBDIR="
        //                    Config.TimeToRenew = Conf[1].Contains("TimeToRenew=") && Conf[1] != "" ? Conf[1].Remove(0, 12) : ""; // Remove "TimeToRenew="
        //                    Config.InstalledDirectory = Conf[2].Contains("InstalledDirectory=") && Conf[2] != "" ? Environment.CurrentDirectory.Remove(0, 19) : ""; // Remove "InstallDir="
        //                }
        //                catch (Exception error)
        //                {
        //                    MessageBox.Show(error.ToString());
        //                }
        //                // IF DATA IS ERASED THEN DELETE CONFIG FILE AND RE-RUN Utilities.GetConfig
        //                if (Config.DBDir_Name == "" || Config.TimeToRenew.ToString() == "" || Config.InstalledDirectory == "")
        //                {
        //                    File.Delete($@"{Environment.CurrentDirectory}\Config.txt");
        //                    Config = Utilities.GetConfigData();
        //                }
        //            }
        //        }
        //        else
        //        { // NO CONFIG DATA FOUND. ASK CREATE NEW.
        //            if (MessageBox.Show("Database settings are not configured or missing. Configure now?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //            {
        //                ConfigForm CF = new ConfigForm();
        //                DialogResult _cf = CF.ShowDialog();
        //                if (_cf == DialogResult.OK)
        //                {
        //                    Config = CF.OutputConfig();
        //                }
        //            }
        //            else
        //            {
        //                Application.Exit();
        //            }
        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        MessageBox.Show(err.ToString());
        //    }

        //    return Config;
        //}

        public static string GetLicenseIDToString (License license)
        {
            try
            {
                return license.Id.ToString();
            }
            catch
            {
                return "";
            }
        }

        public static string GetLicenseName_s(License license)
        {
            string Name;
            try
            {
                // FIND NAME OF SELECTED ROW
                string Company = license.CompanyName;
                string FirstName = license.FirstName;
                string LastName = license.LastName;
                if (Company != "" && FirstName + LastName == "")
                {
                    Name = Company;
                }
                else if (Company != "" && FirstName + LastName != "")
                {
                    Name = $"{Company} ({FirstName} {LastName})";
                }
                else
                {
                    Name = $"{FirstName} {LastName}";
                }
            }
            catch
            {
                Name = "Name Unknown";
            }
            return Name;
        }

        public static string GetLicenseName_s(DataGridView dgv)
        {
            string Name;
            try
            {
                // FIND NAME OF SELECTED ROW
                string Company = dgv[2, dgv.CurrentCell.RowIndex].FormattedValue.ToString();
                string FirstName = dgv[3, dgv.CurrentCell.RowIndex].FormattedValue.ToString();
                string LastName = dgv[4, dgv.CurrentCell.RowIndex].FormattedValue.ToString();
                if (Company != "" && FirstName + LastName == "")
                {
                    Name = Company;
                }
                else if (Company != "" && FirstName + LastName != "")
                {
                    Name = $"{Company} ({FirstName} {LastName})";
                }
                else
                {
                    Name = $"{FirstName} {LastName}";
                }
            }
            catch
            {
                Name = "Name Unknown";
            }
            return Name;
        }


        /// <summary>
        /// Gets count of machines assigned to a lincese
        /// </summary>
        /// <param name="idOfLicense"></param>
        /// <param name="DBDir_Name"></param>
        public static void GetMachineCount_toLabel(int idOfLicense, string DBDir_Name, Label Label)
        {
            // Get Machine Count for Label
            List<LicensedMachines> LM = DataAccess_LicensedMachinesTable.GetByLicenseID(idOfLicense, DBDir_Name);
            Label.Text = LM.Count.ToString();
        }

        public static void GetMachineCount_UpdateDB(int idOfLicense, string DBDir_Name)
        {
            // get license
            License SourceLicense = DataAccess_GDataTable.GetByID(idOfLicense, DBDir_Name);
            // get license machines
            List<LicensedMachines> sourceLicenseMachines = DataAccess_LicensedMachinesTable.GetByLicenseID(SourceLicense.Id, DBDir_Name);
            // count license machines
            SourceLicense.PCCount = sourceLicenseMachines.Count();
            // update License in database with new count
            DataAccess_GDataTable.UpdateLicenseData(SourceLicense, DBDir_Name);
        }

        /// <summary>
        /// Determines if Client already exists in database. It can also return the license(s) found via Out parameter.
        /// "Client" can be company name, first name, last name or partial name.
        /// If "AllNamesMustBeIdentical" is true then Company, First and Last name must be exact.
        /// AllNamesMustBeIdentical is not case sensative. If this is set to false than it will return true if db client even contains inserted name.
        /// </summary>
        /// <param name="Client"></param>
        /// <param name="DBDIR_Name"></param>
        /// <param name="licenseFound"></param>
        /// <returns></returns>
        public static bool ClientExists(License Client, string DBDIR_Name, bool AllNamesMustBeIdentical, out List<License> licenseFound)
        {
            licenseFound = DataAccess_GDataTable.GetByName($"{Client.CompanyName} {Client.FirstName} {Client.LastName}", DBDIR_Name);

            #region Names Must Be Idental
            if (AllNamesMustBeIdentical)
            {
                List<License> identicalLicenseFound = new List<License>();

                foreach(License dblicense in licenseFound)
                {
                    // If License == Client then Client is exact duplicate.
                    if ($"{dblicense.CompanyName} {dblicense.FirstName} {dblicense.LastName}".ToLower() == $"{Client.CompanyName} {Client.FirstName} {Client.LastName}".ToLower())
                    {
                        // Add duplicate client to list of duplicates
                        identicalLicenseFound.Add(dblicense);
                    }
                    

                }

                // Clear licenseFound list
                licenseFound.Clear();
                // Copy duplicate license list to licenseFound list (If non were found it will simply return an empty list)
                licenseFound = identicalLicenseFound;
                
            }
            #endregion

            if (licenseFound.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verify machine doesn't already exist in Database
        /// </summary>
        /// <param name="LicensedMachineName"></param>
        /// <param name="DBDIR_Name"></param>
        public static bool MachineExists(string MachineToLookFor, string DBDIR_Name, out List<int> LicenseIDs)
        {
            List<LicensedMachines> Duplicates = new List<LicensedMachines>();

            // SEARCH FOR DUPLICATES BY NAME
            Duplicates = DataAccess_LicensedMachinesTable.FindDuplicate(MachineToLookFor, DBDIR_Name);

            // DUPLICATE FOUND return true
            if (Duplicates.Count > 0)
            {
                List<int> DupLicenses = new List<int>();
                foreach (LicensedMachines machine in Duplicates)
                {
                    DupLicenses.Add(machine.LicenseId);;
                }
                LicenseIDs = DupLicenses; // Return License ID's
                return true; // Return Duplicate found = true;
            }
            else // NO DUPLICATE FOUND return false
            {
                LicenseIDs = null;
                return false;
            }
        }



        /// <summary>
        /// Verify machine doesn't already exist in Database
        /// </summary>
        /// <param name="LicensedMachine"></param>
        /// <param name="DBDIR_Name"></param>
        /// <param name="LicenseIDs"></param>
        /// <returns></returns>
        public static bool MachineExist(LicensedMachines MachineBeingEdited, string MachineToLookFor, string DBDIR_Name, out List<int> LicenseIDs)
        {
            List<LicensedMachines> Duplicates = new List<LicensedMachines>();

            // SEARCH FOR DUPLICATES BY NAME
            Duplicates = DataAccess_LicensedMachinesTable.FindDuplicate(MachineToLookFor, DBDIR_Name);

            // COMPARE WITH LICENSE BEING EDITED
            List<LicensedMachines> VerifiedDuplicates = new List<LicensedMachines>();
            if (Duplicates.Count > 0)
            {
                foreach (LicensedMachines machine in Duplicates)
                {
                    // Verify the machine with identical name isn't the machine currently being created/edited
                    if (machine.Id != MachineBeingEdited.Id)
                    {
                        VerifiedDuplicates.Add(machine);
                    }
                }
            }

            // DUPLICATE FOUND return value and true
            if (VerifiedDuplicates.Count > 0)
            {

                List<int> DupLicenses = new List<int>();
                foreach (LicensedMachines machine in VerifiedDuplicates)
                {
                    DupLicenses.Add(machine.LicenseId); ;
                }
                LicenseIDs = DupLicenses; // Return License ID's
                return true; // Return Duplicate found = true;
            }
            else // NO DUPLICATE FOUND return false
            {
                LicenseIDs = null;
                return false;
            }
        }


        /// <summary>
        /// Converts 'renewal status' string to an int for use with the RenewalStatus Combobox
        /// </summary>
        /// <param name="LicenseToCheck"></param>
        /// <returns></returns>
        public static int ResolveRenewalStatus_Int(License LicenseToCheck)
        {
            int ValueResolved = 5;
            if (LicenseToCheck.RenewalStatus == "Renewed")
            {
                ValueResolved = 0;
            }
            if (LicenseToCheck.RenewalStatus == "Will Renew")
            {
                ValueResolved = 1;
            }
            if (LicenseToCheck.RenewalStatus == "Pending")
            {
                ValueResolved = 2;
            }
            if (LicenseToCheck.RenewalStatus == "Cancel Pending")
            {
                ValueResolved = 3;
            }
            if (LicenseToCheck.RenewalStatus == "Cancelled")
            {
                ValueResolved = 4;
            }
            if (LicenseToCheck.RenewalStatus == "Undefined")
            {
                ValueResolved = 5;
            }
            return ValueResolved;
        }
       
        public static void SaveMySpot_DGV (DataGridView DataGridView)
        {
            // COLLECT INFO ABOUT CURRENT SELECTION
            int SelectedRow = DataGridView.CurrentCell.RowIndex; ;
            int SelectedColumn = DataGridView.CurrentCell.ColumnIndex;



            try // RETURN TO PREVIOUS PLACE ON LIST
            {
                if (SelectedColumn > 0)
                {
                    DataGridView.CurrentCell = DataGridView.Rows[SelectedRow].Cells[SelectedColumn];
                }
                else
                {
                    DataGridView.CurrentCell = DataGridView.Rows[0].Cells[1];
                }
            }
            catch
            {
            }
        }

        
        public static bool VerifyDatabaseExists(ConfigClass Config)
        {
            FileInfo DBFile = new FileInfo(Config.DBDir_Name);
            return DBFile.Exists ? true : false;
        }

        
        /// <summary>
        /// Checks Database for Updates then asks to Update.
        /// </summary>
        /// <param name="Config"></param>
        public static void CheckDatabaseForUpdates(ConfigClass Config)
        {
            #region Check Licensed Machines Table
            Version DBVer = DataAccess_LicensedMachinesTable.CheckForUpdates(Config);
            #endregion

            #region Check GData Table
            // 
            #endregion

            #region Check Change Log Table
            // 
            #endregion

            // Compare DB Version to current software version.
            if (DBVer < Class_Library.Settings.CurrentSoftwareVersion)
            {
                // Update found
                string Message = $"Database outdated! " +
                    $"\n Database Version: {DBVer.ToString()}" +
                    $"\n Latest Version: {Class_Library.Settings.CurrentSoftwareVersion.ToString()}. " +
                    $"\n What would you like to do?";

                ErrorForm ErrForm = new ErrorForm(Message, "Update DB", "Create New DB");
                DialogResult result = ErrForm.ShowDialog();

                // Solution to the error
                switch (result)
                {
                    case DialogResult.Yes:
                        Utilities.UpdateDatabase(Config, DBVer.ToString());
                        break;
                    case DialogResult.No:
                        // Create New Database
                        ConfigForm CF = new ConfigForm();
                        DialogResult _cf = CF.ShowDialog();
                        if (_cf == DialogResult.OK)
                        {
                            Config = CF.ConfigOutput;
                        }
                        break;
                    case DialogResult.Abort:
                        // Abort entire application
                        Application.Exit();
                        break;
                }
            }
        }


        /// <summary>
        /// Update all Database Tables
        /// </summary>
        /// <param name="Config"></param>
        /// <param name="DBVer"></param>
        private static void UpdateDatabase(ConfigClass Config, string DBVer)
        {
            try
            {
                #region Update Licensed Machines Table
                DataAccess_LicensedMachinesTable.Update(Config.DBDir_Name, DBVer);
                #endregion

                #region Update GData Table

                #endregion

                #region Update Change Log Table

                #endregion
            }
            catch (Exception err)
            {
                MessageBox.Show($"The was an error! \n {err}");
            }
            MessageBox.Show("Database updated successfully!");

        }

        public static bool VerifyNotNull_ComboBox (ComboBox combobox, bool error)
        {
            bool Error = error;
            if (combobox.SelectedItem == null || combobox.SelectedItem.ToString() == "")
            {
                combobox.BackColor = Color.Red;
                Error = true;
            }
            return Error;
        }

        public static bool VerifyNotNull_TextBox (TextBox textbox, bool error)
        {
            bool Error = error;
            if (textbox.Text == null || textbox.Text == "")
            {
                textbox.BackColor = Color.Red;
                Error = true;
            }
            return Error;
        }

        public static bool VerifyNotNull_DateTimePicker(DateTimePicker DateTimePicker, bool error)
        {
            bool Error = error;
            if (DateTimePicker.Value == null || DateTimePicker.Value.ToString() == "")
            {
                DateTimePicker.BackColor = Color.Red;
                Error = true;
            }
            return Error;
        }
    }
}
