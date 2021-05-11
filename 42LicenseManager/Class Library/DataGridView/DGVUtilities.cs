using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    class DGVUtilities
    {
        /// <summary>
        /// Used to get the sortation of a DataGridView table.
        /// NOTE: Make sure to use SetSortation when ready to re-sort.
        /// </summary>
        public static Class_Library.DataGridView.DGVSortInfo GetSortation(DataGridView FromThisDGV)
        {
            Class_Library.DataGridView.DGVSortInfo SavedSortation = new Class_Library.DataGridView.DGVSortInfo();

            try
            {
                SavedSortation.Sortation = FromThisDGV.SortOrder;
                if (FromThisDGV.SortedColumn != null)
                {
                    
                    SavedSortation.SortByColumn = FromThisDGV.SortedColumn.DisplayIndex;
                }
                    
            }
            catch
            {

            }
            return SavedSortation;

            
        }

        /// <summary>
        /// Used to set the sortation of a DataGridView table.
        /// NOTE: Make sure to use GetSortation first!
        /// </summary>
        public static void SetSortation(Class_Library.DataGridView.DGVSortInfo SavedSortation, DataGridView DGVToSort)
        {
            try
            {
                if (SavedSortation.Sortation == SortOrder.Ascending)
                {
                    DGVToSort.Sort(DGVToSort.Columns[SavedSortation.SortByColumn], System.ComponentModel.ListSortDirection.Ascending);
                }
                else
                {
                    DGVToSort.Sort(DGVToSort.Columns[SavedSortation.SortByColumn], System.ComponentModel.ListSortDirection.Descending);
                }
            }
            catch
            {

            }
        }

        public static void SetSortationDefault(int Column, SortOrder Ascending_Descending, DataGridView DGVToSort)
        {
            // SET DEFAULT SORTATION
            Class_Library.DataGridView.DGVSortInfo DefaultSortation = new Class_Library.DataGridView.DGVSortInfo();
            DefaultSortation.Sortation = Ascending_Descending;
            DefaultSortation.SortByColumn = Column;
            DGVUtilities.SetSortation(DefaultSortation, DGVToSort);
        }

        /// <summary>
        /// Used to get the selected row and column of a DataGridView table.
        /// </summary>
        public static Class_Library.DataGridView.DGVPositionInfo GetPosition (DataGridView FromThisDGV)
        {
            Class_Library.DataGridView.DGVPositionInfo SavedPosition = new Class_Library.DataGridView.DGVPositionInfo();

            try
            {
                if (FromThisDGV.RowCount > 0) // This must be here for the first database entry otherwise it is null and causes errors.
                {
                    // GET INFO
                    SavedPosition.SelectedRow = FromThisDGV.CurrentCell.RowIndex;
                    SavedPosition.SelectedColumn = FromThisDGV.CurrentCell.ColumnIndex;
                }
                
            }
            catch
            {

            }

            return SavedPosition;
        }

        public static void SetPosition (Class_Library.DataGridView.DGVPositionInfo SavedPosition, DataGridView DGVtoSet)
        {
            try // RETURN TO PREVIOUS PLACE ON LIST
            {
                if (SavedPosition.SelectedColumn > 0)
                {
                    DGVtoSet.CurrentCell = DGVtoSet.Rows[SavedPosition.SelectedRow].Cells[SavedPosition.SelectedColumn];
                }
                else
                {
                    DGVtoSet.CurrentCell = DGVtoSet.Rows[0].Cells[1];
                }
            }
            catch
            {
            }
        }

        public static List<int> DGVGetColumXofSelectedCell(DataGridView DGV, int Column)
        {
            List<int> ColumnValues = new List<int>();
            try
            {
                foreach (DataGridViewCell cell in DGV.SelectedCells) // For each selected cell in datagridview
                {
                    if (!ColumnValues.Contains(cell.RowIndex)) // If ColumnValues doesn't already contain value
                    {
                        ColumnValues.Add(Convert.ToInt32(DGV[Column, cell.RowIndex].FormattedValue)); // Get/Add ID to ColumnValues List
                    }
                }
            }
            catch
            {

            }
            return ColumnValues;
        }
    }
}
