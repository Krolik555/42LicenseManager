using Equin.ApplicationFramework;
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
    public partial class MoveForm : Form
    {
        public List<LicensedMachines> SelectedMachines_Input { get; set; }
        ConfigClass Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
        List<License> LicensesDGV = new List<License>();
        List<LicensedMachines> LicensedMachinesDGV = new List<LicensedMachines>();
        
        public MoveForm()
        {
            InitializeComponent();
        }
        private void MoveForm_Shown(object sender, EventArgs e)
        {
            // GET DEFAULT DATA
            LicensesDGV = DataAccess_GDataTable.GetAllData(Config.DBDir_Name);
            // PUT DATA INTO SORTABLE LIST
            BindingListView<License> SortableLicensesDGV = new BindingListView<License>(LicensesDGV);
            // SET DGV.DATASOURCE
            aDataGridViewLicenses.DataSource = SortableLicensesDGV;
            // SET DEFAULT SORTATION
            DGVUtilities.SetSortationDefault(5, SortOrder.Descending, aDataGridViewLicenses);
            Utilities.CloseSQLConnection();
        }
        private void ATextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //GET SORTATION
            Class_Library.DataGridView.DGVSortInfo SavedSortation = DGVUtilities.GetSortation(aDataGridViewLicenses);

            // SEARCH FOR DATA
            LicensesDGV = DataAccess_GDataTable.GetByName(aTextBoxSearch.Text, Config.DBDir_Name);

            // PUT DATA INTO SORTABLE LIST
            BindingListView<License> SortableLicensesDGV = new BindingListView<License>(LicensesDGV);
            // SET DGV.DATASOURCE
            aDataGridViewLicenses.DataSource = SortableLicensesDGV;
            // SET SORTATION
            DGVUtilities.SetSortation(SavedSortation, aDataGridViewLicenses);
        }

        private void ADataGridViewLicenses_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // GET LICENSED MACHINES OF SELECTED LICENSE
                int IDOfSelectedLicense = (Convert.ToInt32(aDataGridViewLicenses[0, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue));
                LicensedMachinesDGV = DataAccess_LicensedMachinesTable.GetByLicenseID(IDOfSelectedLicense, Config.DBDir_Name);
                BindingListView<LicensedMachines> SortableLicensedMachinesDGV = new BindingListView<LicensedMachines>(LicensedMachinesDGV);
                aDataGridViewMachines.DataSource = SortableLicensedMachinesDGV;

                DGVUtilities.SetSortationDefault(2, SortOrder.Ascending, aDataGridViewMachines);
                Utilities.CloseSQLConnection();
            }
            catch
            {

            }
        }

        private void AButtonMoveHere_Click(object sender, EventArgs e)
        {
            try
            {
                // GET ID OF DESTINATION LICENSE
                int DestinationLicenseID = (Convert.ToInt32(aDataGridViewLicenses[0, aDataGridViewLicenses.CurrentCell.RowIndex].FormattedValue));
                License DestinationLicense = DataAccess_GDataTable.GetByID(DestinationLicenseID, Config.DBDir_Name);
                // GET OLD LICENSE ID FOR UPDATING PURPOSES
                int SourceLicenseID = SelectedMachines_Input[0].LicenseId;
                License SourceLicense = DataAccess_GDataTable.GetByID(SourceLicenseID, Config.DBDir_Name);

                // UPDATE LICENSED MACHINES DATABASE
                foreach (LicensedMachines machine in SelectedMachines_Input)
                {
                    // SET NEW LICENSEID
                    LicensedMachines OriginalMachine = new LicensedMachines();
                    LicensedMachines ChangedMachine = new LicensedMachines();
                    machine.CopyDataTo(OriginalMachine);
                    machine.CopyDataTo(ChangedMachine);
                    ChangedMachine.LicenseId = DestinationLicenseID;
                    // UPDATE
                    DataAccess_LicensedMachinesTable.UpdateLicenseId(ChangedMachine, Config.DBDir_Name);
                    // FIND CHANGES MADE
                    List<string> ChangesMade = Utilities.FindChanges(OriginalMachine, ChangedMachine);
                    // CREATE LOG
                    Utilities.CreateLog(ChangesMade, SourceLicenseID);
                }

                // UPDATE MACHINE COUNT
                Utilities.GetMachineCount_UpdateDB(SourceLicenseID, Config.DBDir_Name);
                Utilities.GetMachineCount_UpdateDB(DestinationLicenseID, Config.DBDir_Name);

                

                // Success!
                MessageBox.Show($"Successfully moved {SelectedMachines_Input.Count} machine(s) " +
                    $"\nFrom {Utilities.GetLicenseName_s(SourceLicense)} ID: {SourceLicenseID.ToString()}" +
                    $"\nTo {Utilities.GetLicenseName_s(DestinationLicense)} ID: {DestinationLicenseID.ToString()}");

                Utilities.CloseSQLConnection();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void ATextBoxSearch_Leave(object sender, EventArgs e)
        {
            Utilities.CloseSQLConnection();
        }
    }
}
