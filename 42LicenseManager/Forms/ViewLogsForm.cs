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
    public partial class ViewLogsForm : Form
    {
        public License InputLicense { get; set; }
        public bool GetAllLogs { get; set; }
        ConfigClass Config = Class_Library.Config.Get();

        public ViewLogsForm()
        {
            InitializeComponent();
        }

        private void ViewLogsForm_Shown(object sender, EventArgs e)
        {
            DataAccess_ChangeLogTable db = new DataAccess_ChangeLogTable();
            if (GetAllLogs == true && InputLicense == null)
            {
                List<LogClass> Alllogs = db.GetLogs_GetAllLogs(Config.DBDir_Name);
                BindingListView<LogClass> AllSortableLogsDGV = new BindingListView<LogClass>(Alllogs);
                aDataGridViewLogs.DataSource = AllSortableLogsDGV;
                aDataGridViewLogs.Sort(aDataGridViewLogs.Columns[1], ListSortDirection.Descending);
            }
            if (GetAllLogs == false && InputLicense != null)
            {
                List<LogClass> logs = db.GetLogs_ByLicenseId(InputLicense.Id, Config.DBDir_Name);
                BindingListView<LogClass> SortableLogsDGV = new BindingListView<LogClass>(logs);
                aDataGridViewLogs.DataSource = SortableLogsDGV;
                aDataGridViewLogs.Sort(aDataGridViewLogs.Columns[1], ListSortDirection.Descending);
            }
        }

        private void aButtonDeleteLog_Click(object sender, EventArgs e)
        {
            List<int> SelectedRows = new List<int>();
            //SelectedRows = Utilities.DGVGetSelectedRows_Int(aDataGridViewLogs); // Gets Row Id of each selected row/cell.
            SelectedRows = DGVUtilities.DGVGetColumXofSelectedCell(aDataGridViewLogs, 0); // Gets Row Id of each selected row/cell.
            int SelectedRowIndex = aDataGridViewLogs.CurrentCell.RowIndex;

            
            if (SelectedRows.Count >= 1)
            {
                // VERIFY DELETE
                DialogResult dialogResultMulti = MessageBox.Show($"Are you sure you want to delete the selected logs from the database?", "Verification", MessageBoxButtons.YesNo);
                if (dialogResultMulti == DialogResult.Yes)
                {
                    // DELETE SELECTED ROW/S
                    foreach (int row in SelectedRows)
                    {
                        DataAccess_ChangeLogTable db = new DataAccess_ChangeLogTable();
                        db.DeleteLog(row, Config.DBDir_Name);
                    }
                    // REFRESH LOGS
                    ViewLogsForm_Shown(this, e);
                    if (SelectedRowIndex > 0)
                    {
                        aDataGridViewLogs.CurrentCell = aDataGridViewLogs.Rows[SelectedRowIndex - 1].Cells[1];
                    }
                    else
                    {
                        aDataGridViewLogs.CurrentCell = aDataGridViewLogs.Rows[SelectedRowIndex].Cells[1];
                    }
                }
                
            }
        }

        private void aButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
