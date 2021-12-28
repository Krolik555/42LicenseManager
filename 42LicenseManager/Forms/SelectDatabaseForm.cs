using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager.Forms
{
    public partial class SelectDatabaseForm : Form
    {
        // Passed in values
        List<string> dbLibrary = new List<string>();
        List<string> dbNames = new List<string>();

        // Return values
        public string returnSelectedDatabaseFilePath { get; set; }
        public string returnSelectedDatabaseName { get; set; }
        public string returnSelectedDatabaseDirectory_Only { get; set; }
        public string returnSelectedDatabaseConfigFilePath { get; set; }


        public SelectDatabaseForm()
        {
            InitializeComponent();

        }

        private void SelectDatabaseForm_Load(object sender, EventArgs e)
        {
            // Get list of existing databases (directories and file names) then store them in dbDirectories and dbNames
            dbLibrary = Class_Library.DatabaseLibrary.Get();

            // Get database names from database library for easier reading in DGV
            dbNames.Clear();
            foreach(string line in dbLibrary)
            {
                string _dbName = Path.GetFileName(line);
                if (!File.Exists(line))
                {
                    _dbName = $"Missing! - {_dbName}";
                }

                dbNames.Add(_dbName);
            }

            // clear datagridview if contains content
            if(aDGVDatabases.RowCount > 0)
            {
                aDGVDatabases.Rows.Clear();
            }

            // Add database library to datagridview
            for(int Row = 0; Row < dbLibrary.Count; Row++)
            {
                aDGVDatabases.Rows.Add(dbNames[Row], dbLibrary[Row]);
            }
        }

        private void aButtonSelect_Click(object sender, EventArgs e)
        {
            // If No rows are selected > tell user
            if (aDGVDatabases.SelectedRows == null)
            {
                MessageBox.Show("No database selected");
            }
            else // If row is selected then load database
            {
                // Return selected values
                returnSelectedDatabaseName = (string)aDGVDatabases[0, aDGVDatabases.CurrentCell.RowIndex].Value;
                returnSelectedDatabaseFilePath = (string)aDGVDatabases[1, aDGVDatabases.CurrentCell.RowIndex].Value;
                
                // Detect if DB file is missing or directory has been changed.
                if (!returnSelectedDatabaseName.Contains("Missing!"))
                {
                    // if database file is included in path, remove it.
                    if (returnSelectedDatabaseFilePath.EndsWith(".mdf"))
                    {
                        returnSelectedDatabaseDirectory_Only = Path.GetDirectoryName(returnSelectedDatabaseFilePath) + @"\";
                    }
                    // Verify the directory ends with '\'
                    if (!returnSelectedDatabaseDirectory_Only.EndsWith(@"\"))
                    {
                        returnSelectedDatabaseDirectory_Only += @"\";
                    }
                    // Add config file name to path
                    returnSelectedDatabaseConfigFilePath = returnSelectedDatabaseDirectory_Only + "Config.txt";


                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Notify user of missing DB file
                    MessageBox.Show("This file is missing. Please delete this listing and add your database again.", "Alert!");
                }

                
            }
        }

        private void aButtonAdd_Click(object sender, EventArgs e)
        {
            ConfigForm _configform = new ConfigForm();
            DialogResult _Configform = _configform.ShowDialog();
            if (_Configform == DialogResult.OK)
            {
                SelectDatabaseForm_Load(sender, e);

                _configform.Close();
            }
            else
            {
               
            }
        }

        private void aButtonRemove_Click(object sender, EventArgs e)
        {
            if (aDGVDatabases.RowCount > 0)
            {
                Class_Library.DatabaseLibrary.Remove((string)aDGVDatabases[1, aDGVDatabases.CurrentCell.RowIndex].Value);
                aDGVDatabases.Rows.RemoveAt(aDGVDatabases.CurrentCell.RowIndex);
                SelectDatabaseForm_Load(sender, e);
            }
            
        }

        private void aDGVDatabases_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            aButtonSelect_Click(sender, e);
        }

        private void aDGVDatabases_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value.ToString().Contains("Missing!"))
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }
    }
}
