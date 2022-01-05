using _42LicenseManager.Class_Library;
using _42LicenseManager.Forms;
using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    public partial class Dashboard : Form
    {

        /// <summary>
        /// List used to supply sortable data to DGV in Dashboard
        /// </summary>
        public static List<License> LicensesDGV = new List<License>();
        public string USERNAME = Environment.UserName;

        /// <summary>
        /// this is selected by the user during program load
        /// </summary>
        //public static string SelectedDatabase;

        /// <summary>
        /// Contains the data from the configuration file that is stored on the computer.
        /// </summary>
        public ConfigClass Config = new ConfigClass();
        Version CurrentVer = Assembly.GetExecutingAssembly().GetName().Version;


        public Dashboard()
        {
            
            InitializeComponent();

            // Get Current software version
            Class_Library.Settings.CurrentSoftwareVersion = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Select Database
                SelectDatabaseForm dbLibraryForm = new SelectDatabaseForm();
                DialogResult selectedDB = dbLibraryForm.ShowDialog();
                if (selectedDB == DialogResult.OK)
                {
                    // Set the Database selected by user
                    Class_Library.Settings.SelectedDatabaseFilePath = dbLibraryForm.returnSelectedDatabaseFilePath;
                    Class_Library.Settings.SelectedDatabaseDirectory_Only = dbLibraryForm.returnSelectedDatabaseDirectory_Only;
                    Class_Library.Settings.SelectedDatabaseConfigFilePath = dbLibraryForm.returnSelectedDatabaseConfigFilePath;
                }
                else
                {
                    this.Close();
                }

                
                // VERIFY INTEGRITY OF CONFIG & DATABASE | GET CONFIG INFO
                Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);

                // Check If DB is current Version
                Utilities.CheckDatabaseForUpdates(Config);

                // Check if Licenses are up for renewal
                InitializeLicensesTTR();

                // #Finish Setup#
                // SELECT DEFAULT VIEW
                aComboboxSortBy.SelectedIndex = 0;

                DGVUtilities.SetSortationDefault(5, SortOrder.Descending, aDataGridViewLicenses);

                // Determine if db has ever been backed up. (if it hasn't then the backupExpiration date will be 1/1/0001)
                string LastBackup = Config.LastBackup < DateTime.Now.AddYears(-10) ? "Never" : Config.LastBackup.ToString();
                // Set Title Name
                UpdateTitleBar();

                backgroundWorkerAutoBackup.RunWorkerAsync();

            }
            catch (System.Data.SqlClient.SqlException err)
            {
                // General SQL error message
                string errorMessage = $"Error message:\n\"{err.Message}\" \n\nWould you like to re-configure your database settings?";

                // SQL Login Failed error message
                if (err.Message.Contains("Login Failed"))
                {
                    errorMessage = $"Error message:\n\"{err.Message}\" " +
                        $"\n\n" +
                        $"This is likely due to another machine accessing the databse file. Typically this can be resolved by restarting the application." +
                        $"\n\n" +
                        $"Would you like to re-configure your database settings?";
                }
                

                DialogResult dresult = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.YesNo); // Unable to Access Database
                if (dresult == DialogResult.Yes) // If user wants to change database directory
                {
                    // SETUP CONFIG FORM -- to re-configure database
                    ConfigForm _configform = new ConfigForm(Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath));
                    DialogResult _Configform = _configform.ShowDialog();
                    if (_Configform == DialogResult.OK)
                    {
                        Application.Restart(); // If User saves changes to Database directory
                    }
                    else
                    {
                        Application.Exit(); // If user decides to change nothing
                    }
                }
                else // If user does NOT want to change database directory
                {
                    Application.Exit();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void InitializeLicensesTTR() // Determine if licenses are up for renewal
        {
            List<License> AllLicenses = new List<License>();

            try
            {
                AllLicenses = DataAccess_GDataTable.GetAllData(Config.DBDir_Name);
            }
            catch // GetAllData failed
            {
                
            }
            

            foreach (License _License in AllLicenses)
            {
                if (DateTime.Now >= _License.ExpirationDate.AddDays(-(Convert.ToInt32(Config.TimeToRenew))) && _License.Active == true && _License.RenewalStatus == "Renewed") // If it expires within 21 days and is currently active
                {
                    _License.ReviewStatus = "Open";
                    _License.RenewalStatus = "";
                    DataAccess_GDataTable.UpdateLicenseData(_License, Config.DBDir_Name);
                }
            }
            Utilities.CloseSQLConnection();
        }

        private void aButtonCheckForExpires_Click(object sender, EventArgs e)
        {
            InitializeLicensesTTR();

            RefreshDashboard(this, e);
        }

        private void aButtonSearch_Click(object sender, EventArgs e)
        {
            aTextBoxNotes.Text = "";
            //GET SORTATION
            Class_Library.DataGridView.DGVSortInfo SavedSortation = DGVUtilities.GetSortation(aDataGridViewLicenses);


            // GET DATA BY NAME
            if (aComboboxSortBy.SelectedItem.ToString() == @"Search by Name\Id")
            {
                // Get licenses by name
                LicensesDGV = DataAccess_GDataTable.GetByName(aTextBoxSearch.Text, Config.DBDir_Name);
                // Get licenses by ID
                if (int.TryParse(aTextBoxSearch.Text, out int value))
                {
                    List<License> LicensesByID = DataAccess_GDataTable.GetByID(Convert.ToInt32(aTextBoxSearch.Text), Config.DBDir_Name);
                    foreach (License _license in LicensesByID)
                    {
                        LicensesDGV.Add(_license);
                    }
                }
                

            }
            // OR GET DATA BY MACHINE NAME
            else if (aComboboxSortBy.SelectedItem.ToString() == "Search by Machine Name")
            {
                List<LicensedMachines> LicenseFound = DataAccess_LicensedMachinesTable.GetByMachineName(aTextBoxSearch.Text, Config.DBDir_Name);
                try
                {
                    // FIND LICENSES BY MACHINE'S LICENSE ID
                    List<License> TempLicensesDGV = new List<License>();
                    foreach (LicensedMachines _Lic in LicenseFound)
                    {
                        // COMPILE LIST FOR DGV. Get licenses by ID but only add the 1st found.
                        TempLicensesDGV.Add((DataAccess_GDataTable.GetByID(_Lic.LicenseId, Config.DBDir_Name))[0]);
                    }
                    // MOVE LIST TO DGV
                    LicensesDGV = TempLicensesDGV;
                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }

            // PUT DATA INTO SORTABLE LIST
            BindingListView<License> SortableLicensesDGV = new BindingListView<License>(LicensesDGV);

            // SET DGV.DATASOURCE
            aDataGridViewLicenses.DataSource = SortableLicensesDGV;
            aLabelLicenseFoundInt.Text = aDataGridViewLicenses.Rows.Count.ToString();
            // SET SORTATION
            DGVUtilities.SetSortation(SavedSortation, aDataGridViewLicenses);
            Utilities.CloseSQLConnection();

            // If no licenses were found, clear the notes text box.
            if (aDataGridViewLicenses.RowCount == 0)
            {
                aTextBoxNotes.Text = "";
            }
        }

        private void ATextBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // When enter pressed in search field
            if (e.KeyCode == Keys.Return)
            {
                aButtonSearch_Click(this, e);
            }
        }
        private void ATextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            aButtonSearch_Click(this, e);
        }

        private void aButtonEdit_Click(object sender, EventArgs e)
        {
            License SelectedLicense = new License();
            License SelectedLicense_Changed = new License();
            EditForm _editForm = new EditForm();
            
            // GET DATA
            try
            {
                // GET SELECTED LICENSE FROM DB VIA ID
                SelectedLicense = (DataAccess_GDataTable.GetByID(Convert.ToInt32(aDataGridViewLicenses[0, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue), Config.DBDir_Name)[0]);
            }
            catch
            {
                MessageBox.Show("Please Select a row");
                return;
            }

            // LAUNCH EDIT FORM
            if (SelectedLicense != null)
            {
                _editForm.InputLicense = SelectedLicense; // Set License to be passed in
                DialogResult _form = _editForm.ShowDialog();
                if (_form == DialogResult.OK) // When editform.Savebutton is clicked
                {
                    SelectedLicense_Changed = _editForm.OutputLicense(); // launch Edit form and return values to SelectedLicense_Changed

                    if (SelectedLicense_Changed != SelectedLicense)
                    {
                        // Update SQL DB using changed License
                        DataAccess_GDataTable.UpdateLicenseData(SelectedLicense_Changed, Config.DBDir_Name);

                        // FIND CHANGES
                        List<string> ChangesMade = Utilities.FindChanges(SelectedLicense, SelectedLicense_Changed);
                        // CREATE/SAVE LOGS
                        Utilities.CreateLog(ChangesMade, SelectedLicense.Id);
                    }
                    RefreshDashboard(this, e);
                }

                #region Open Duplicate Client Account

                if (_form == DialogResult.Abort)
                {
                    _editForm.InputLicense = _editForm.ChangedLicense; // Set License to be passed in
                    DialogResult _form2 = _editForm.ShowDialog();
                    if (_form2 == DialogResult.OK) // When editform.Savebutton is clicked
                    {
                        SelectedLicense_Changed = _editForm.OutputLicense(); // launch Edit form and return values to SelectedLicense_Changed

                        if (SelectedLicense_Changed != SelectedLicense)
                        {
                            // Update SQL DB using changed License
                            DataAccess_GDataTable.UpdateLicenseData(SelectedLicense_Changed, Config.DBDir_Name);

                            // FIND CHANGES
                            List<string> ChangesMade = Utilities.FindChanges(SelectedLicense, SelectedLicense_Changed);
                            // CREATE/SAVE LOGS
                            Utilities.CreateLog(ChangesMade, SelectedLicense.Id);
                        }
                        RefreshDashboard(this, e);
                    }
                }
                #endregion Open Duplicate Client Account

            }
            else
            {
                MessageBox.Show("No license selected to edit");
            }
            RefreshDashboard(this, e);
        }

        private void aButtonAddLicense_Click(object sender, EventArgs e)
        {

            License NewLicense = new License();
            AddLicenseForm _AddLicenseForm = new AddLicenseForm();
            DialogResult _form = _AddLicenseForm.ShowDialog();

            #region SAVE AND ADD MACHINES BUTTON
            if (_form == DialogResult.Yes) 
            {
                // GET NEW LICENSE INFO from AddLicenseForm
                NewLicense = _AddLicenseForm.OutputLicense();

                // ADD NEW LICENSE TO SQL DB
                if (NewLicense != null)
                {
                    DataAccess_GDataTable.CreateNewLicense(NewLicense, Config.DBDir_Name);
                }

                InitializeLicensesTTR();

                // GET CREATED LICENSE FROM DB
                List<License> LatestEntry = new List<License>();
                LatestEntry = DataAccess_GDataTable.GetLatestEntry(Config.DBDir_Name);
                // CHECK FOR EMPTY LATESTENTRY
                if (LatestEntry[0].CompanyName == null || LatestEntry[0].FirstName == null && LatestEntry[0].LastName == null)
                {
                    MessageBox.Show("There was an error getting the most recently added license.", "Error!");
                    return;
                }

                // LOG LICENSE CREATION DATE
                LogLicenseCreationDate(LatestEntry);

                
                RefreshDashboard(this, e);

                // NEXT STEP: MANAGE MACHINES FORM
                ManagePCsForm _ManagePCsForm = new ManagePCsForm();
                _ManagePCsForm.InputLicense = LatestEntry[0]; // Set License to be passed in
                DialogResult _manageform = _ManagePCsForm.ShowDialog();
                if (_manageform == DialogResult.OK || _manageform == DialogResult.Cancel)
                {
                    RefreshDashboard(this, e);
                }
                
            }
            #endregion Save and Add Machines

            #region Save
            if (_form == DialogResult.OK) // SAVE BUTTON
            {
                // COLLECT DATA FROM CREATED LICENSE
                NewLicense = _AddLicenseForm.OutputLicense();

                // Update DB using UpdatedLicense
                if (NewLicense != null)
                {
                    DataAccess_GDataTable.CreateNewLicense(NewLicense, Config.DBDir_Name);
                }

                // GET LICENSE CREATED FROM DB
                List<License> LicenseFromDB = DataAccess_GDataTable.GetLatestEntry(Config.DBDir_Name);

                // LOG LICENSE CREATION DATE
                LogLicenseCreationDate(LicenseFromDB);

                InitializeLicensesTTR();
                RefreshDashboard(this, e);
            }
            #endregion Save

            #region Open Duplicate Client Account
            if (_form == DialogResult.Abort)
            {
                License SelectedLicense = new License();
                License SelectedLicense_Changed = new License();
                EditForm _editForm = new EditForm();
                // GET DATA
                try
                {
                    // GET SELECTED LICENSE FROM DB VIA ID
                    SelectedLicense = _AddLicenseForm.OutputLicense();
                }
                catch
                {
                    MessageBox.Show("Please Select a row");
                    return;
                }

                // LAUNCH EDIT FORM
                if (SelectedLicense != null)
                {
                    _editForm.InputLicense = SelectedLicense; // Set License to be passed in
                    DialogResult _editformResult = _editForm.ShowDialog();
                    if (_editformResult == DialogResult.OK) // When editform.Savebutton is clicked
                    {
                        SelectedLicense_Changed = _editForm.OutputLicense(); // launch Edit form and return values to SelectedLicense_Changed

                        if (SelectedLicense_Changed != SelectedLicense)
                        {
                            // Update SQL DB using changed License
                            DataAccess_GDataTable.UpdateLicenseData(SelectedLicense_Changed, Config.DBDir_Name);

                            // FIND CHANGES
                            List<string> ChangesMade = Utilities.FindChanges(SelectedLicense, SelectedLicense_Changed);
                            // CREATE/SAVE LOGS
                            Utilities.CreateLog(ChangesMade, SelectedLicense.Id);
                        }
                        RefreshDashboard(this, e);
                    }
                }
                else
                {
                    MessageBox.Show("No license selected to edit");
                }
                RefreshDashboard(this, e);
            }
            #endregion Open Duplicate Client Account

            
        }

        public void LogLicenseCreationDate(List<License> LicenseFromDB)
            {
                // LOG LICENSE CREATION DATE
                List<string> changesmade = new List<string>();
                if (LicenseFromDB[0].CompanyName == "")
                {
                    changesmade.Add($"License Created for '{LicenseFromDB[0].FirstName} {LicenseFromDB[0].LastName}'");
                }
                else
                {
                    changesmade.Add($"License Created for '{LicenseFromDB[0].CompanyName}'");
                }
                Utilities.CreateLog(changesmade, LicenseFromDB[0].Id);
            }

        private void aButtonDelete_Click(object sender, EventArgs e)
        {
            int SelectedIndex = 0;
            string Name;
            try
            {
                // FIND NAME OF SELECTED ROW
                string Company = aDataGridViewLicenses[2, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue.ToString();
                string FirstName = aDataGridViewLicenses[3, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue.ToString();
                string LastName = aDataGridViewLicenses[4, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue.ToString();
                if (Company != "" && FirstName + LastName == "")
                {
                    Name = Company;
                }
                else if(Company != "" && FirstName + LastName != "")
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
                MessageBox.Show("Please Select a row");
                return;
            }
            // CONFIRM DELETE
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete '{Name}' from the database?", "Verification", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                // GET SELECTED ROW FOR PLACE HOLDER.
                SelectedIndex = aDataGridViewLicenses.CurrentCell.RowIndex;

                // GET ACCOUNTS ID for cleaning purposes
                int LicenseToDeleteID = Convert.ToInt32(aDataGridViewLicenses[0, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue);

                // DELETE ASSOCIATED LOGS
                DataAccess_ChangeLogTable.DeleteLogByLicenseID(LicenseToDeleteID, Config.DBDir_Name);

                // DELETE ASSOCIATED MACHINES
                DataAccess_LicensedMachinesTable.DeleteLicensedMachineBYLicenseId(LicenseToDeleteID, Config.DBDir_Name);

                // DELETE LICENSE
                DataAccess_GDataTable.DeleteLicense(Convert.ToInt32(aDataGridViewLicenses[0, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue), Config.DBDir_Name);
            }
            RefreshDashboard(this, e);
        }

        private void aButtonViewAllLogs_Click(object sender, EventArgs e)
        {
            ViewLogsForm LogsForm = new ViewLogsForm();
            LogsForm.GetAllLogs = true; // Set License to be passed in
            DialogResult _form = LogsForm.ShowDialog();
        }

        private void aComboboxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Class_Library.DataGridView.DGVSortInfo SavedSortation = new Class_Library.DataGridView.DGVSortInfo();
            SavedSortation = DGVUtilities.GetSortation(aDataGridViewLicenses);
            if (aComboboxSortBy.SelectedItem.ToString() == "Opened Licenses")
            {
                Utilities.EnableSearch(aButtonSearch, aTextBoxSearch, aLabelSearch, false);
                LicensesDGV = DataAccess_GDataTable.GetByReviewStatus("Open", Config.DBDir_Name);
                BindingListView<License> SortableLicensesDGV = new BindingListView<License>(LicensesDGV);
                aDataGridViewLicenses.DataSource = SortableLicensesDGV;
                aLabelLicenseFoundInt.Text = aDataGridViewLicenses.Rows.Count.ToString();
            }
            if (aComboboxSortBy.SelectedItem.ToString() == @"Search by Name\Id")
            {
                Utilities.EnableSearch(aButtonSearch, aTextBoxSearch, aLabelSearch, true);
            }
            if (aComboboxSortBy.SelectedItem.ToString() == "Search by Machine Name")
            {
                Utilities.EnableSearch(aButtonSearch, aTextBoxSearch, aLabelSearch, true);
            }
            if (aComboboxSortBy.SelectedItem.ToString() == "All Licenses")
            {
                Utilities.EnableSearch(aButtonSearch, aTextBoxSearch, aLabelSearch, false);

                LicensesDGV = DataAccess_GDataTable.GetAllData(Config.DBDir_Name);
                BindingListView<License> SortableLicensesDGV = new BindingListView<License>(LicensesDGV);
                aDataGridViewLicenses.DataSource = SortableLicensesDGV;
                aLabelLicenseFoundInt.Text = aDataGridViewLicenses.Rows.Count.ToString();
            }
            DGVUtilities.SetSortation(SavedSortation, aDataGridViewLicenses);
            Utilities.CloseSQLConnection();
        }

        private void AButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDashboard(this, e);
        }
        
        private void aDataGridViewLicenses_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Get notes from selected license (Local data, not from SQL)
            aTextBoxNotes.Text = (aDataGridViewLicenses[9, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue.ToString());
            // Get auto-renew state from selected license (Local data, not from SQL)
            aCheckBoxAutoRenew.Checked = (Convert.ToBoolean(aDataGridViewLicenses[10, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue));
        }

        private void setDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SETUP CONFIG FORM
            ConfigForm _configform = new ConfigForm(Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath));
            DialogResult _Configform = _configform.ShowDialog();
            if (_Configform == DialogResult.OK)
            {
                Application.Restart();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm _aboutForm = new AboutForm();
            DialogResult _AFDR = _aboutForm.ShowDialog();
        }

        private void aDataGridViewLicenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // VERIFY SELECTED IS NOT COLUMN HEADER
            if (e.RowIndex != -1)
            {
                // EDIT SELECTED ROW
                aButtonEdit_Click(this, e);
            }
        }

        private void aDataGridViewLicenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // FORMAT CELLS W/ COLOR
            if (e.ColumnIndex == 1)
            {
                try
                {
                    if (e.Value.ToString() == "Open")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                }
                catch
                {

                }
            }
            if (e.ColumnIndex == 6)
            {
                if (e.Value.ToString() == "Renewed")
                {
                    e.CellStyle.BackColor = Color.LawnGreen;
                }
                if (e.Value.ToString() == "Will Renew")
                {
                    e.CellStyle.BackColor = Color.DarkSeaGreen;
                }
                if (e.Value.ToString() == "Pending")
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
                if (e.Value.ToString() == "Cancel Pending")
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                }
                if (e.Value.ToString() == "Cancelled")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                if (e.Value.ToString() == "Undefined")
                {
                    e.CellStyle.BackColor = Color.PowderBlue;
                }
            }

        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                MessageBox.Show("Return pressed");
            }
        }

        

        /// <summary>
        /// Refresh the DGV in Dashboard Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshDashboard(object sender, EventArgs e)
        {
            aTextBoxNotes.Text = "";
            // GET SORTATION INFO
            Class_Library.DataGridView.DGVSortInfo SavedSortation = DGVUtilities.GetSortation(aDataGridViewLicenses);
            // GET POSITION
            Class_Library.DataGridView.DGVPositionInfo SavedPosition = DGVUtilities.GetPosition(aDataGridViewLicenses);

            // REFRESH DASHBOARD
            aComboboxSortBy_SelectedIndexChanged(sender, e);
            aButtonSearch_Click(sender, e);

            // SET SORTATION
            DGVUtilities.SetSortation(SavedSortation, aDataGridViewLicenses);
            // SET POSITION
            DGVUtilities.SetPosition(SavedPosition, aDataGridViewLicenses);

            Utilities.CloseSQLConnection();
        }

       
        private void aButtonTest_Click(object sender, EventArgs e)
        {
            UpdateTitleBar();
        }

        private void ATextBoxSearch_Leave(object sender, EventArgs e)
        {
            Utilities.CloseSQLConnection();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configureBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupForm backupForm = new BackupForm();
            DialogResult DR = backupForm.ShowDialog();
            if (DR == DialogResult.OK)
            {
                Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
                if (Config.AutoBackup && !backgroundWorkerAutoBackup.IsBusy)
                {
                    //If autoBackup was just turned off that means the background worker is dead.
                    // Start the background worker back up.
                    backgroundWorkerAutoBackup.RunWorkerAsync();
                }
            }
        }

        private void backupNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DRBackupPrompt = MessageBox.Show("Backup now?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DRBackupPrompt == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                // Get Backup Target Directory
                string BackupDir = Config.BackupTarget_PathOnly;
                // Get backup Target File name
                string backupFileName = Path.GetFileName(Config.DBDir_Name);
                // Backup
                if (Config.DBDir_Name != "" && backupFileName != "" && BackupDir != "")
                {
                    
                    backgroundWorkerBackup.RunWorkerAsync();

                }
                else
                {
                    MessageBox.Show("Backup is not configured properly. Go to 'Edit > Configure Backup' to correct this issue.", "Backup Failed!", MessageBoxButtons.OK);
                }
            }
            


        }

        private void selectDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #region Backup async processes

        /// <summary>
        /// Last time program checked for backup
        /// </summary>
        public static DateTime LastBackupCheck { get; set; }

        private void backgroundWorkerBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            

            Class_Library.Backup.Now(Config.DBDir_Name, Path.GetFileName(Config.DBDir_Name), Config.BackupTarget_PathOnly);
            Backup.ClearOldBackups(Config.BackupTarget_PathOnly);

            // Update title bar with last backup date
            UpdateTitleBar();


            t.Abort();
        }

        void Splash()
        {
            //Open a splash screen form
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.Font = new Font("Time New Romans", 7);
            frm.AppName = "Backup In Progress";
            frm.ShowIcon = false;
            frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(frm);
        }


        private void backgroundWorkerBackup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorkerBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Update Title with last backup date/time
            UpdateTitleBar();
        }


        private void backgroundWorkerAutoBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Config.AutoBackup)
            {
                LastBackupCheck = DateTime.Now;

                // if last backup exceeds time limit
                if (Backup.TimeToBackup(LastBackupCheck))
                {
                    // Get config data from file
                    ConfigClass config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);

                    // Backup
                    Class_Library.Backup.AutoBackup(config.DBDir_Name, Path.GetFileName(config.DBDir_Name), config.BackupTarget_PathOnly);
                    Class_Library.Backup.ClearOldBackups(config.BackupTarget_PathOnly);

                    UpdateTitleBar();
                }
                else
                {
                    // sleep for 10 minutes
                    Thread.Sleep(600000);
                }
            }
        }


        #endregion

        private void importLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Launch ImportForm
            Forms.Import_License.ImportForm Importfrm = new Forms.Import_License.ImportForm();
            DialogResult DR = Importfrm.ShowDialog();
            // If user submits data from the ImportForm (dialogresult == yes)
            if (DR == DialogResult.Yes)
            {
                // Get valid licenses from ImportForm
                List<License> LicensesQueuedForImport = new List<License>();
                LicensesQueuedForImport = Importfrm.VerifiedLicenses;

                #region License is Not a duplicate
                foreach (License VerifiedLicense in LicensesQueuedForImport)
                {
                    
                    // If License is NOT a duplicate
                    if (!Utilities.ClientExists(VerifiedLicense, Class_Library.Settings.SelectedDatabaseFilePath, true, out List<License> DuplicatefromSQLDB))
                    {
                        // Set license as active - it is freshly added so there won't be any previous settings.
                        VerifiedLicense.Active = true;
                        VerifiedLicense.RenewalStatus = "Renewed";

                        // Update DB using Verified License
                        if (VerifiedLicense != null)
                        {
                            DataAccess_GDataTable.CreateNewLicense(VerifiedLicense, Config.DBDir_Name);
                        }

                        // GET LICENSE CREATED FROM DB for use with logs
                        List<License> LicenseFromDB = DataAccess_GDataTable.GetLatestEntry(Config.DBDir_Name);

                        // LOG LICENSE CREATION DATE
                        LogLicenseCreationDate(LicenseFromDB);

                        //List<string> changesmade = new List<string>();
                        //if (VerifiedLicense.CompanyName == "")
                        //{
                        //    changesmade.Add($"License Created for '{NewLicense2[0].FirstName} {NewLicense2[0].LastName}'");
                        //}
                        //else
                        //{
                        //    changesmade.Add($"License Created for '{NewLicense2[0].CompanyName}'");
                        //}
                        //Utilities.CreateLog(changesmade, NewLicense2[0].Id);
                    }
                    #endregion License is Not a duplicate

                    #region License IS a duplicate
                    // If license IS a duplicate
                    else
                    {
                        // If duplicates NOT allowed
                        if (!Config.AllowDuplicateClients)
                        {
                            try // Merge dupe licenses with current licenses.
                            {
                                // There should only be one license
                                // Set imported license ID to that of the duplicate in the SQL DB.
                                VerifiedLicense.Id = DuplicatefromSQLDB[0].Id;
                                VerifiedLicense.ReviewStatus = DuplicatefromSQLDB[0].ReviewStatus;
                                VerifiedLicense.RenewalStatus = DuplicatefromSQLDB[0].RenewalStatus.ToString() != "Cancelled" ? DuplicatefromSQLDB[0].RenewalStatus : "Renewed";
                                //VerifiedLicense.Active = true; License is set to Active before duplicate check.
                                VerifiedLicense.Notes = DuplicatefromSQLDB[0].Notes;
                                VerifiedLicense.PCCount = DuplicatefromSQLDB[0].PCCount;
                                DataAccess_GDataTable.UpdateLicenseData(VerifiedLicense, Config.DBDir_Name);
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                            }

                        }
                        else
                        {

                        }

                    }
                    #endregion License IS a duplicate

                }
                Config.LastDataImport = DateTime.Now;
                Class_Library.Config.Update(Config);
                UpdateTitleBar();
                InitializeLicensesTTR();
                RefreshDashboard(this, e);

            }
        }

        private void aCheckBoxAutoRenew_Click(object sender, EventArgs e)
        {
            #region Work-around used to make the checkbox read-only.
            if (aCheckBoxAutoRenew.Checked)
            {
                aCheckBoxAutoRenew.Checked = false;
            }
            else
            {
                aCheckBoxAutoRenew.Checked = true;
            }
            #endregion
        }

        private void UpdateTitleBar()
        {
            Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
            // InvokeRequired is used for cross-thread execution
            if (this.InvokeRequired)
            {
                this.Invoke(new ThreadStart(delegate
                {
                    this.Text = $"42 License Manager v.{CurrentVer} (Current Database: {Path.GetFileName(Config.DBDir_Name)})" +
                    $" | Last backup: {Config.LastBackup} | Last data import: {Config.LastDataImport}";
                }));
            }
            else //if no cross-threading, execute normally.
            {
                // Updates last backup time in Title bar
                this.Text = $"42 License Manager v.{CurrentVer} (Current Database: {Path.GetFileName(Config.DBDir_Name)})" +
                        $" | Last backup: {Config.LastBackup} | Last data import: {Config.LastDataImport}";
            }
        }
    }
}
