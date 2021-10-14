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
            Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);

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
            #region Verify Fields
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

            if (aComboboxRenewalStatus.SelectedItem.ToString() == "Renewed" && aComboboxReviewStatus.SelectedItem.ToString() == "Open")
            {
                MessageBox.Show("You have marked this license as Renewed but it is still open for review. Would you like to close the review status of this license?", "Possible Problem");
            }
            {

            }
            #endregion Verify Fields

            #region Check Duplicate Clients
            bool Close = false;
            do
            {

                
                License ModifiedClient = new License();
                ModifiedClient.CompanyName = aTextBoxCompanyName.Text;
                ModifiedClient.FirstName = aTextBoxFirstName.Text;
                ModifiedClient.LastName = aTextBoxLastName.Text;

                // Check if any names have been modified (Company, first, Last)
                if (
                    ModifiedClient.CompanyName != InputLicense.CompanyName || 
                    ModifiedClient.FirstName != InputLicense.FirstName || 
                    ModifiedClient.LastName != InputLicense.LastName
                    )
                {
                    // Get current user if exists and store in 'ExistingUser'
                    List<License> ExistingUser = new List<License>();
                    if (Utilities.ClientExists(ModifiedClient, Class_Library.Settings.SelectedDatabaseFilePath, true, out ExistingUser))
                    {
                        do
                        {
                            ConfigClass Config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);

                            // Are duplicate clients allowed?
                            if (Config.AllowDuplicateClients) // yes
                            {
                                // Get user input
                                if (MessageBox.Show("This client already exists. \n \n Would you like to create the client anyway?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    // create client like normal
                                    break;
                                }
                                else // if user says no (user doesn't want to create client)
                                {
                                    // cancel save
                                    return;
                                }
                            }
                            else // no
                            {
                                if (MessageBox.Show("This client already exists. \n \n Would you like to view that client now?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {

                                    // GET Duplicate LICENSE info FROM DB VIA ID
                                    try
                                    {
                                        ChangedLicense = (DataAccess_GDataTable.GetByID(ExistingUser[0].Id, Config.DBDir_Name)[0]);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Error getting Client data");
                                        return;
                                    }
                                    // Mark program to close. Can't close it at this level.
                                    Close = true;
                                    break;

                                }
                                else
                                {
                                    return;
                                }
                            }
                        } while (false);
                    }
                    else
                    {
                        // Continue with normal procedure
                    }
                }

                

                if (Close == true)
                {
                    // Tell Dashboard to load edit form with the dupe customer's info
                    this.DialogResult = DialogResult.Abort;
                    break;
                }
                #endregion Check Cuplicate Client


                #region Edit DB with inputed Client data
                // Save data to OutputLicense which will be sent back to Dashboard to be added to the DB
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
                }
            }
            while (false);

            this.Close();
            #endregion Edit Client with inputed data

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
                //aCheckBoxWillCancel.Enabled = true;
            }
            else
            {
                aCheckBoxDeleted.Enabled = false;
                aCheckBoxUninstalled.Enabled = false;
                //aCheckBoxWillCancel.Enabled = false;
            }
        }

        private void aButtonRenew_Click(object sender, EventArgs e)
        {
            aComboboxReviewStatus.SelectedIndex = 1;
            aComboboxActive.SelectedIndex = 0;
            aComboboxRenewalStatus.SelectedIndex = 0;
            RenewClicked = true;
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

        private void aCheckBoxAdvanced_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Warning: If you import your licenses from another system, the names in 42LicenseManager and your other system need to remain identical. \n" +
                "If one gets changed but not the other, the next time you import licenses, it will create a new license resulting in potential duplicates.");
            bool isVisible = false;
            bool isReadOnly = true;
            if (aCheckBoxAdvanced.Checked)
            {
                isVisible = true;
                isReadOnly = false;
            }
            //aLabelCompanyName.Enabled = result;
            //aLabelFirstName.Enabled = result;
            //aLabelLastName.Enabled = result;
            aTextBoxCompanyName.ReadOnly = isReadOnly;
            aTextBoxFirstName.ReadOnly = isReadOnly;
            aTextBoxLastName.ReadOnly = isReadOnly;
            //aLabelReviewStatus.Visible = isVisible;
            //aComboboxReviewStatus.Visible = isVisible;
            aLabelActive.Visible = isVisible;
            aComboboxActive.Visible = isVisible;
        }


    }
}
