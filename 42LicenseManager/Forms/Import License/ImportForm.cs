using Equin.ApplicationFramework;
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

namespace _42LicenseManager.Forms.Import_License
{
    public partial class ImportForm : Form
    {

        public List<License> VerifiedLicenses = new List<License>();
        public List<License> FailedLicenses = new List<License>();

        public ImportForm()
        {
            InitializeComponent();
        }

        private void aBtnBrowse_Click(object sender, EventArgs e)
        {
            // Browse for File
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Select a file";
            openDialog.Filter = "SCV Files (*.csv) | *.csv";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                aTextBoxSource.Text = openDialog.FileName;
            }
        }

        private void aBtnAnalyze_Click(object sender, EventArgs e)
        {
            // Clear old data
            if (VerifiedLicenses.Count > 0) { VerifiedLicenses.Clear(); }
            if (FailedLicenses.Count > 0) { FailedLicenses.Clear(); }

            // Analyze selected file if exists
            if (File.Exists(aTextBoxSource.Text))
            {
                // Read CSV file
                DataTable csvTable = Class_Library.Import_License.CSV.Read(aTextBoxSource.Text);
                if (csvTable == null)
                {
                    return;
                }

                // Translate previously read data and convert to "License" format.
                // During this coversion it will put incompatible licenses into the FailedLicenses list. The rest go in VerifiedLicenses list.
                // Note: This does not compare current data with SQL data in search of duplicates.
                Class_Library.Import_License.CSV.TranslateData(csvTable, VerifiedLicenses, FailedLicenses, aComboboxFormat.SelectedItem.ToString());

                // Add data to verified DGV table
                BindingListView<License> SortableLicensesVerified = new BindingListView<License>(VerifiedLicenses);
                aDGVVerified.DataSource = SortableLicensesVerified;

                // Add data to failed DGV table
                BindingListView<License> SortableLicensesFailed = new BindingListView<License>(FailedLicenses);
                aDGVFailed.DataSource = SortableLicensesFailed;

                // Set Verified licenses count
                aLabelVerifiedCount.Text = VerifiedLicenses.Count.ToString();

                // Set failed licenses count
                aLabelFailedCount.Text = FailedLicenses.Count.ToString();

                if (!aButtonSubmit.Enabled)
                {
                    aButtonSubmit.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Selected file does not exist.");
            }
        }

        private void aDGVVerified_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            aTextBoxVerifiedNotes.Text = (aDGVVerified[9, aDGVVerified.CurrentCell.RowIndex].FormattedValue.ToString());
        }

        private void aDGVFailed_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            aTextBoxFailedNotes.Text = (aDGVFailed[9, aDGVFailed.CurrentCell.RowIndex].FormattedValue.ToString());
        }

        private void aButtonSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void aLinkLabelTemplate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Control destination of aLinkLabelTemplate
            if (aComboboxFormat.SelectedItem.ToString() == "Avast Business Cloud Care")
            {
                System.Diagnostics.Process.Start("https://github.com/Krolik555/42LicenseManager_Instructions.git");
            }
            else
            {
                
            }
            
        }

        private void aComboboxFormat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Control visibility of aLinkLabelTemplate
            if (aComboboxFormat.SelectedItem.ToString() == "Avast Business Cloud Care")
            {
                aLinkLabelTemplate.Visible = true;
            }
            else
            {
                aLinkLabelTemplate.Visible = false;
            }
            if (aComboboxFormat.SelectedItem.ToString() == null)
            {
                aButtonSubmit.Enabled = false;
                aBtnBrowse.Enabled = false;
                aBtnAnalyze.Enabled = false;
            }
            else
            {
                aButtonSubmit.Enabled = true;
                aBtnBrowse.Enabled = true;
                aBtnAnalyze.Enabled = true;
            }
        }
    }
}
