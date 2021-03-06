﻿using _42LicenseManager.Class_Library;
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
        /// Contains the data from the configuration file that is stored on the computer.
        /// </summary>
        public ConfigClass Config = new ConfigClass();
        public int MyProperty { get; set; }
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
                // VERIFY INTEGRITY OF CONFIG & DATABASE | GET CONFIG INFO
                //Config = Utilities.GetConfigData();
                Config = Class_Library.Config.Get();

                // Check If DB is current Version
                Utilities.CheckDatabaseForUpdates(Config);

                // Check if Licenses are up for renewal
                InitializeLicensesTTR();

                // #Finish Setup#
                // SELECT DEFAULT VIEW
                aComboboxSortBy.SelectedIndex = 0;

                DGVUtilities.SetSortationDefault(5, SortOrder.Descending, aDataGridViewLicenses);
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
                    ConfigForm _configform = new ConfigForm();
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

            if (aComboboxSortBy.SelectedItem.ToString() == @"Search by Name\Id")
            {

                // GET DATA BY NAME
                LicensesDGV = DataAccess_GDataTable.GetByName(aTextBoxSearch.Text, Config.DBDir_Name);
            }
            else if (aComboboxSortBy.SelectedItem.ToString() == "Search by Machine Name")
            {
                // GET DATA BY MACHINE NAME
                List<LicensedMachines> LicenseFound = DataAccess_LicensedMachinesTable.GetByMachineName(aTextBoxSearch.Text, Config.DBDir_Name);
                try
                {
                    // FIND LICENSES BY MACHINE'S LICENSE ID
                    List<License> TempLicensesDGV = new List<License>();
                    foreach (LicensedMachines _Lic in LicenseFound)
                    {
                        // COMPILE LIST FOR DGV
                        TempLicensesDGV.Add(DataAccess_GDataTable.GetByID(_Lic.LicenseId, Config.DBDir_Name));
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
                SelectedLicense = DataAccess_GDataTable.GetByID(Convert.ToInt32(aDataGridViewLicenses[0, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue), Config.DBDir_Name);
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

            if (_form == DialogResult.Yes) // SAVE AND ADD MACHINES BUTTON
            {
                // GET NEW LICENSE INFO from add license form
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
                List<string> changesmade = new List<string>();
                if (NewLicense.CompanyName == "")
                {
                    changesmade.Add($"License Created for '{LatestEntry[0].FirstName} {LatestEntry[0].LastName}'");
                }
                else
                {
                    changesmade.Add($"License Created for '{LatestEntry[0].CompanyName}'");
                }
                Utilities.CreateLog(changesmade, LatestEntry[0].Id);

                
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
                List<License> NewLicense2 = new List<License>();
                NewLicense2 = DataAccess_GDataTable.GetLatestEntry(Config.DBDir_Name);

                // LOG LICENSE CREATION DATE
                List<string> changesmade = new List<string>();
                if (NewLicense.CompanyName == "")
                {
                    changesmade.Add($"License Created for '{NewLicense2[0].FirstName} {NewLicense2[0].LastName}'");
                }
                else
                {
                    changesmade.Add($"License Created for '{NewLicense2[0].CompanyName}'");
                }
                Utilities.CreateLog(changesmade, NewLicense2[0].Id);

                InitializeLicensesTTR();
                RefreshDashboard(this, e);
            }
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
            aTextBoxNotes.Text = (aDataGridViewLicenses[9, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue.ToString());
        }

        private void setDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SETUP CONFIG FORM
            ConfigForm _configform = new ConfigForm();
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

        }

        private void ATextBoxSearch_Leave(object sender, EventArgs e)
        {
            Utilities.CloseSQLConnection();
        }

    }
}
