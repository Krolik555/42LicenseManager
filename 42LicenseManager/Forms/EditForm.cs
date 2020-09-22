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
    public partial class EditForm : Form
    {
        public License InputLicense { get; set; }
        public License ChangedLicense = new License();
        ConfigClass Config = new ConfigClass();
        public bool RenewClicked = false; // Used for the "Renew 1 Yr" button.

        public EditForm()
        {
            InitializeComponent();
            Config = Utilities.GetConfigData();
            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void EditForm_Shown(object sender, EventArgs e)
        {
            WireupForm();
            InputLicense.CopyDataTo(ChangedLicense);
        }
        public void WireupForm()
        {
            // Get data from passed in License (InputLicense)
            if (InputLicense.ReviewStatus == "Open")
            {
                aComboboxReviewStatus.SelectedIndex = 0; // Open
            }
            else
            {
                aComboboxReviewStatus.SelectedIndex = 1; // Closed
            }
            aTextBoxCompanyName.Text = InputLicense.CompanyName;
            aTextBoxFirstName.Text = InputLicense.FirstName;
            aTextBoxLastName.Text = InputLicense.LastName;
            aTextBoxNotes.Text = InputLicense.Notes;
            aDateTimePickerExpirationDate.Value = InputLicense.ExpirationDate;
            if (InputLicense.Active == true)
            {
                aComboboxActive.SelectedIndex = 0; // True (Active)
            }
            else
            {
                aComboboxActive.SelectedIndex = 1; // False (Expired)
            }
            // Check current renewal status
            int RenewalStatusTemp = Utilities.ResolveRenewalStatus_Int(InputLicense);
            if (RenewalStatusTemp < 6) // 6 = Status is blank.
            {
                aComboboxRenewalStatus.SelectedIndex = RenewalStatusTemp;
            }
            else
            {
                aComboboxRenewalStatus.SelectedText = "";
            }
            aCheckBoxWillCancel.Checked = InputLicense.ChkBxWillCancel;
            aCheckBoxUninstalled.Checked = InputLicense.ChkBxUninstalled;
            aCheckBoxDeleted.Checked = InputLicense.ChkBxDeleted;
            Utilities.GetMachineCount_toLabel(InputLicense.Id, Config.DBDir_Name, aLabelMachinesCount);
        }

        private void aButtonAddYear_Click(object sender, EventArgs e)
        {
            aDateTimePickerExpirationDate.Value = aDateTimePickerExpirationDate.Value.AddYears(1);
        }

        private void aButtonManagePCs_Click(object sender, EventArgs e)
        {
            try
            {
                ManagePCsForm _ManagePCsForm = new ManagePCsForm();
                _ManagePCsForm.InputLicense = InputLicense; // Set License to be passed in
                DialogResult _form = _ManagePCsForm.ShowDialog();
                if (_form == DialogResult.OK) // When editform.Savebutton is clicked
                {
                    Utilities.GetMachineCount_toLabel(InputLicense.Id, Config.DBDir_Name, aLabelMachinesCount);
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("There was a problem connecting to the database." +
                    "\nTo prevent any corruption, the program will restart.", "Login Failed!");
                Utilities.CloseSQLConnection();
                Application.Restart();
            }
        }

        private void aButtonSave_Click(object sender, EventArgs e)
        {
            bool error = false;
            // VERIFY REQUIRED FIELDS ARE FILLED
            if (aTextBoxCompanyName.Text == "" && (aTextBoxFirstName.Text == "" || aTextBoxLastName.Text == ""))
            {
                error = true;
                MessageBox.Show("Company Name OR First and Last Name required.");
            }
            error = Utilities.VerifyNotNull_ComboBox(aComboboxActive, error);
            error = Utilities.VerifyNotNull_ComboBox(aComboboxReviewStatus, error);
            error = Utilities.VerifyNotNull_DateTimePicker(aDateTimePickerExpirationDate, error);

            if (aComboboxRenewalStatus.SelectedItem.ToString() == "Undefined")
            {
                DialogResult DResult = MessageBox.Show("You haven't changed the Renewal Status. Is this okay?", "Warning!", MessageBoxButtons.YesNo);
                if (DResult == DialogResult.No)
                {
                    error = true;
                }
            }

            if (!error)
            {
                // Prepare new data for export
                ChangedLicense.CompanyName = aTextBoxCompanyName.Text;
                ChangedLicense.ReviewStatus = aComboboxReviewStatus.SelectedItem.ToString();
                ChangedLicense.FirstName = aTextBoxFirstName.Text;
                ChangedLicense.LastName = aTextBoxLastName.Text;
                ChangedLicense.ExpirationDate = aDateTimePickerExpirationDate.Value;
                ChangedLicense.PCCount = Convert.ToInt32(aLabelMachinesCount.Text);
                ChangedLicense.RenewalStatus = aComboboxRenewalStatus.SelectedItem.ToString();
                if (aComboboxActive.SelectedItem.ToString() == "False")
                {
                    ChangedLicense.Active = false;
                }
                else
                {
                    ChangedLicense.Active = true;
                }
                ChangedLicense.Notes = aTextBoxNotes.Text;
                ChangedLicense.ChkBxWillCancel = aCheckBoxWillCancel.Checked;
                ChangedLicense.ChkBxUninstalled = aCheckBoxUninstalled.Checked;
                ChangedLicense.ChkBxDeleted = aCheckBoxDeleted.Checked;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void aButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public License OutputLicense()
        {
            return ChangedLicense;
        }

        private void aButtonViewLogs_Click(object sender, EventArgs e)
        {
            ViewLogsForm LogsForm = new ViewLogsForm();
            LogsForm.InputLicense = InputLicense; // Set License to be passed in
            DialogResult _form = LogsForm.ShowDialog();
            if (_form == DialogResult.OK) // When editform.Savebutton is clicked
            {
                
            }
        }

        private void AComboboxRenewalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aComboboxRenewalStatus.SelectedIndex == 3)// 3 = Cancel Pending
            {
                aCheckBoxDeleted.Enabled = true;
                aCheckBoxUninstalled.Enabled = true;
                aCheckBoxWillCancel.Enabled = true;
            }
            else
            {
                aCheckBoxDeleted.Enabled = false;
                aCheckBoxUninstalled.Enabled = false;
                aCheckBoxWillCancel.Enabled = false;
            }
        }

        private void AButtonRenewOneYear_Click(object sender, EventArgs e)
        {
            bool cancel = false;
            if (RenewClicked == true)
            {
                DialogResult DResult = MessageBox.Show("You have already clicked 'renew 1 year'. " +
                    "Would you like to add another year to this license?","Alert!",MessageBoxButtons.YesNo);
                if (DResult == DialogResult.No)
                {
                    cancel = true;
                }
            }
            if (cancel == false)
            {
                aComboboxReviewStatus.SelectedIndex = 1;
                aButtonAddYear_Click(this, e);
                aComboboxActive.SelectedIndex = 0;
                aComboboxRenewalStatus.SelectedIndex = 0;
                RenewClicked = true;
            }
            
        }

        private void AButtonCancelLicense_Click(object sender, EventArgs e)
        {
            aComboboxReviewStatus.SelectedIndex = 1;
            aComboboxActive.SelectedIndex = 1;
            aComboboxRenewalStatus.SelectedIndex = 4;
        }
    }
}
