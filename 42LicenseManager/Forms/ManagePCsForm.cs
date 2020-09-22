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
    public partial class ManagePCsForm : Form
    {
        public License InputLicense { get; set; }
        public int MachineCount { get; set; }
        ConfigClass Config = Utilities.GetConfigData();


        public ManagePCsForm()
        {
            InitializeComponent();

        }


        private void ManagePCsForm_Shown(object sender, EventArgs e)
        {
            RefreshDataGridViewTable();
        }

        public void RefreshDataGridViewTable()
        {
            // Get Data from Database
            List<LicensedMachines> LM = DataAccess_LicensedMachinesTable.GetByLicenseID(InputLicense.Id, Config.DBDir_Name);
            BindingListView<LicensedMachines> SortableLM = new BindingListView<LicensedMachines>(LM);
            aDataGridViewMachines.DataSource = SortableLM;
            Utilities.CloseSQLConnection();
        }

        private void aButtonAdd_Click(object sender, EventArgs e)
        {
            AddMachinesForm AddForm = new AddMachinesForm();
            AddForm.LicenseID = InputLicense.Id; // Set License to be passed in
            DialogResult _form = AddForm.ShowDialog();
            if (_form == DialogResult.OK) // When editform.Savebutton is clicked
            {
                RefreshDataGridViewTable();
            }
        }

        private void aButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // SAVE POSITION AND SORTATION
                Class_Library.DataGridView.DGVPositionInfo DGVPOS = DGVUtilities.GetPosition(aDataGridViewMachines);
                Class_Library.DataGridView.DGVSortInfo DGVSortInfo = DGVUtilities.GetSortation(aDataGridViewMachines);

                EditLicensedMachineForm Eform = new EditLicensedMachineForm();
                // GET MACHINE BY ID COLUMN OF SELECTED ROW
                Eform.InputMachine = DataAccess_LicensedMachinesTable.GetByID(Convert.ToInt32(aDataGridViewMachines[0, aDataGridViewMachines.CurrentCell.RowIndex].FormattedValue), Config.DBDir_Name);
                // LAUNCH EDIT FORM
                DialogResult _eform = Eform.ShowDialog();
                if (_eform == DialogResult.OK)
                {
                    RefreshDataGridViewTable();

                    // SET POSITION AND SORTATION
                    DGVUtilities.SetPosition(DGVPOS, aDataGridViewMachines);
                    // Check if user has sorted columns yet. If not, leave it at default (do nothing).
                    if (DGVSortInfo.SortByColumn != 0 && DGVSortInfo.Sortation != SortOrder.None)
                    {
                        DGVUtilities.SetSortation(DGVSortInfo, aDataGridViewMachines);
                    }
                    
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No machines are selected.", "Edit Failed");
            }
        }

        private void aButtonDelete_Click(object sender, EventArgs e)
        {
            // SAVE POSITION AND SORTATION
            Class_Library.DataGridView.DGVPositionInfo DGVPOS = DGVUtilities.GetPosition(aDataGridViewMachines);
            Class_Library.DataGridView.DGVSortInfo DGVSortInfo = DGVUtilities.GetSortation(aDataGridViewMachines);

            if (aDataGridViewMachines.SelectedCells.Count > 1) // IF MULTIPLE MACHINES ARE SELECTED
            {
                // INSTANTIATE LIST FOR STORING MACHINE ID'S
                List<int> SelectedMachines_ID = new List<int>(); 

                // GET LIST OF MACHINE ID'S
                SelectedMachines_ID = DGVUtilities.DGVGetColumXofSelectedCell(aDataGridViewMachines, 0); 


                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {SelectedMachines_ID.Count()} machines from the database?", "Verification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // GET CHANGES MADE
                    List<string> ChangesMade = new List<string>();
                    ChangesMade.Add($"Deleted {SelectedMachines_ID.Count} machines.");

                    // CREATE LOG OF DELETED MACHINE
                    Utilities.CreateLog(ChangesMade, InputLicense.Id);

                    // DELETE MACHINE
                    DataAccess_LicensedMachinesTable.DeleteLicensedMachine(SelectedMachines_ID, Config.DBDir_Name);
                }
            }
            else if (aDataGridViewMachines.SelectedCells.Count == 1) // IF 1 MACHINE IS SELECTED
            {
                // CONFIRM DELETE
                string MachineName = $"{aDataGridViewMachines[2, aDataGridViewMachines.CurrentCell.RowIndex].FormattedValue.ToString()}";
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete '{MachineName}' from the database?", "Verification", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // GET CHANGES MADE
                    List<string> ChangesMade = new List<string>();
                    ChangesMade.Add($"Deleted Machine: '{MachineName}'");

                    // CREATE LOG OF DELETED MACHINE
                    Utilities.CreateLog(ChangesMade, InputLicense.Id);

                    // DELETE MACHINE
                    DataAccess_LicensedMachinesTable.DeleteLicensedMachine(Convert.ToInt32(aDataGridViewMachines[0, aDataGridViewMachines.CurrentCell.RowIndex].FormattedValue), Config.DBDir_Name);
                }
            }
            else // IF NO MACHINES ARE SELECTED
            {
                return;
            }

            RefreshDataGridViewTable();
            // SET POSITION AND SORTATION
            DGVPOS.SelectedRow -= 1; // Minus 1 for cases where the last machine in the list was deleted.
            DGVUtilities.SetPosition(DGVPOS, aDataGridViewMachines);
            DGVUtilities.SetSortation(DGVSortInfo, aDataGridViewMachines);
        }

        private void ManagePCsForm_Load(object sender, EventArgs e)
        {

        }

        private void aButtonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ManagePCsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ConfigClass Updated_Config = Utilities.GetConfigData();

            // Get Machine Count for Label
            List<LicensedMachines> LM = DataAccess_LicensedMachinesTable.GetByLicenseID(InputLicense.Id, Config.DBDir_Name);

            License ChangedLicense = new License();
            InputLicense.CopyDataTo(ChangedLicense);
            ChangedLicense.PCCount = LM.Count;
            DataAccess_GDataTable.UpdateLicenseData(ChangedLicense, Config.DBDir_Name);
        }

        private void aDataGridViewMachines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // VERIFY SELECTED IS NOT COLUMN HEADER
            if (e.RowIndex != -1)
            {
                // EDIT SELECTED ROW
                aButtonEdit_Click(this, e);
            }
            
        }
        private void AButtonMove_Click(object sender, EventArgs e)
        {
            try
            {
                // GET ROW INDEX OF SELECTED CELL(S)
                List<int> rowIndexes = (from sc in aDataGridViewMachines.SelectedCells.Cast<DataGridViewCell>()
                                        select sc.RowIndex).Distinct().ToList();

                // GET ID OF EACH MACHINE SELECTED
                List<int> SelectedMachines_ID = new List<int>();
                foreach(int SelectedRow in rowIndexes)
                {
                    SelectedMachines_ID.Add(Convert.ToInt32(aDataGridViewMachines[0, SelectedRow].FormattedValue));
                }

                // GET LICENSED MACHINES SELECTED
                List<LicensedMachines> MachinesSelectedToMove = new List<LicensedMachines>();
                foreach (int MachineID in SelectedMachines_ID)
                {
                    MachinesSelectedToMove.Add(DataAccess_LicensedMachinesTable.GetByID(MachineID, Config.DBDir_Name));
                }

                // LAUNCH MOVE FORM
                MoveForm moveForm = new MoveForm();
                moveForm.SelectedMachines_Input = MachinesSelectedToMove;
                DialogResult _moveForm = moveForm.ShowDialog();
                if (_moveForm == DialogResult.OK)
                {
                    RefreshDataGridViewTable();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
