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
    public partial class AddLicenseForm : Form
    {
        public License ChangedLicense = new License();


        public AddLicenseForm()
        {
            InitializeComponent();
        }

        private void AddLicenseForm_Shown(object sender, EventArgs e)
        {
            WireupForm();
            aComboboxReviewStatus.SelectedIndex = 1;
            aComboboxActive.SelectedIndex = 0;
            aComboboxRenewalStatus.SelectedIndex = 0;
        }
        public void WireupForm()
        {
            //aDateTimePickerExpirationDate.Value = aDateTimePickerExpirationDate.Value.AddYears(1);
        }

        private void aButtonSaveAddMachines_Click(object sender, EventArgs e)
        {
            // VERIFY FIELDS
            bool error = false;
            if (aTextBoxCompanyName.Text == "" && (aTextBoxFirstName.Text == "" || aTextBoxLastName.Text == ""))
            {
                error = true;
                MessageBox.Show("Company Name and/or First and Last Name required.");
            }
            error = Utilities.VerifyNotNull_ComboBox(aComboboxActive, error);
            error = Utilities.VerifyNotNull_ComboBox(aComboboxReviewStatus, error);
            error = Utilities.VerifyNotNull_DateTimePicker(aDateTimePickerExpirationDate, error);

            if (error != true) // if no errors
            {
                // Save data to output license
                ChangedLicense.CompanyName = aTextBoxCompanyName.Text;
                ChangedLicense.FirstName = aTextBoxFirstName.Text;
                ChangedLicense.LastName = aTextBoxLastName.Text;
                ChangedLicense.ReviewStatus = aComboboxReviewStatus.SelectedItem.ToString();
                ChangedLicense.ExpirationDate = aDateTimePickerExpirationDate.Value;
                ChangedLicense.PCCount = 0;
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
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void aButtonSave_Click(object sender, EventArgs e)
        {
            #region Verify Fields
            // VERIFY FIELDS
            bool error = false;
            if (aTextBoxCompanyName.Text == "" && (aTextBoxFirstName.Text == "" || aTextBoxLastName.Text == ""))
            {
                error = true;
                MessageBox.Show("Company Name and/or First and Last Name required.");
            }
            error = Utilities.VerifyNotNull_ComboBox(aComboboxActive, error);
            error = Utilities.VerifyNotNull_ComboBox(aComboboxReviewStatus, error);
            error = Utilities.VerifyNotNull_DateTimePicker(aDateTimePickerExpirationDate, error);
            #endregion Verify Fields

            // Create a license with current info
            ChangedLicense.CompanyName = aTextBoxCompanyName.Text;
            ChangedLicense.FirstName = aTextBoxFirstName.Text;
            ChangedLicense.LastName = aTextBoxLastName.Text;
            ChangedLicense.ReviewStatus = aComboboxReviewStatus.SelectedItem.ToString();
            ChangedLicense.ExpirationDate = aDateTimePickerExpirationDate.Value;
            ChangedLicense.PCCount = 0;
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

            #region Check Duplicate Client
            // DETERMINE IF CLIENT IS DUPLICATE HERE. Logic goes like this: 
            // If client doesn't exist, add it. 
            // If Client exists but is deactivated then reactivate it or offer to reactivate it
            // If Client exists and is active, maybe notify user? but basically do nothing.

            bool Close = false;

            do
            {
                // Get current user if exists and store in 'ExistingUser'
                List<License> ExistingUser = new List<License>();
                if (Utilities.ClientExists(ChangedLicense, Class_Library.Settings.SelectedDatabaseFilePath, true, out ExistingUser))
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
                                    // This data will be used to load the EditForm
                                    ChangedLicense = (DataAccess_GDataTable.GetByID(ExistingUser[0].Id, Config.DBDir_Name)[0]);
                                }
                                catch
                                {
                                    MessageBox.Show("Error getting Client data");
                                    return;
                                }
                                // Mark program to close. I can't close it at this level.
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
                #endregion Check Duplicate Client

                if (Close == true)
                {
                    // Tell Dashboard to load edit form with the dupe customer's info
                    this.DialogResult = DialogResult.Abort;
                    break;
                }

                // Save data to OutputLicense which will be sent back to Dashboard to be added to the DB
                if (error != true)
                {
                    //ChangedLicense.CompanyName = aTextBoxCompanyName.Text;
                    //ChangedLicense.FirstName = aTextBoxFirstName.Text;
                    //ChangedLicense.LastName = aTextBoxLastName.Text;
                    //ChangedLicense.ReviewStatus = aComboboxReviewStatus.SelectedItem.ToString();
                    //ChangedLicense.ExpirationDate = aDateTimePickerExpirationDate.Value;
                    //ChangedLicense.PCCount = 0;
                    //ChangedLicense.RenewalStatus = aComboboxRenewalStatus.SelectedItem.ToString();
                    //if (aComboboxActive.SelectedItem.ToString() == "False")
                    //{
                    //    ChangedLicense.Active = false;
                    //}
                    //else
                    //{
                    //    ChangedLicense.Active = true;
                    //}
                    //ChangedLicense.Notes = aTextBoxNotes.Text;
                    this.DialogResult = DialogResult.OK;
                    
                }
            }
            while (false);

            this.Close();
        }

        public License OutputLicense()
        {
            return ChangedLicense;
        }

        private void aButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void aButtonAddYear_Click(object sender, EventArgs e)
        {
            aDateTimePickerExpirationDate.Value = aDateTimePickerExpirationDate.Value.AddYears(1);
        }

        private void aButtonTest_Click(object sender, EventArgs e)
        {
            
        }

        private void aTextBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            aTextBoxFirstName.BackColor = Color.White;
        }

        private void aTextBoxLastName_TextChanged(object sender, EventArgs e)
        {
            aTextBoxLastName.BackColor = Color.White;
        }

        private void aComboboxReviewStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            aComboboxReviewStatus.BackColor = Color.White;
        }

        private void aComboboxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            aComboboxActive.BackColor = Color.White;
        }

        private void aButtonManagePCs_Click(object sender, EventArgs e)
        {
            ManagePCsForm _ManagePCsForm = new ManagePCsForm();
            _ManagePCsForm.InputLicense = ChangedLicense; // Set License to be passed in
            DialogResult _form = _ManagePCsForm.ShowDialog();
            if (_form == DialogResult.OK) // When editform.Savebutton is clicked
            {
                
            }
        }

        private void ACheckBoxAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if (aCheckBoxAdvanced.Checked)
            {
                aComboboxReviewStatus.Enabled = true;
                aComboboxActive.Enabled = true;
                aComboboxRenewalStatus.Enabled = true;
            }
            else
            {
                aComboboxReviewStatus.Enabled = false;
                aComboboxActive.Enabled = false;
                aComboboxRenewalStatus.Enabled = false;
            }
        }
    }
}
