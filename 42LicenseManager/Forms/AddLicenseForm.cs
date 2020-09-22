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

            if (error != true)
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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
