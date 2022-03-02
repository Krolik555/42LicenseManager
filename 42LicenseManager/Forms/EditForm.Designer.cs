namespace _42LicenseManager
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.aTextBoxNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aLabelActive = new System.Windows.Forms.Label();
            this.aLabelExpirationDate = new System.Windows.Forms.Label();
            this.aTextBoxLastName = new System.Windows.Forms.TextBox();
            this.aLabelFirstName = new System.Windows.Forms.Label();
            this.aLabelLastName = new System.Windows.Forms.Label();
            this.aTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.aComboboxActive = new System.Windows.Forms.ComboBox();
            this.aComboboxRenewalStatus = new System.Windows.Forms.ComboBox();
            this.aButtonSave = new System.Windows.Forms.Button();
            this.aButtonCancel = new System.Windows.Forms.Button();
            this.aComboboxReviewStatus = new System.Windows.Forms.ComboBox();
            this.aLabelReviewStatus = new System.Windows.Forms.Label();
            this.aButtonAddYear = new System.Windows.Forms.Button();
            this.aDateTimePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.aLabelPCsLicensed = new System.Windows.Forms.Label();
            this.aButtonManagePCs = new System.Windows.Forms.Button();
            this.aLabelMachinesCount = new System.Windows.Forms.Label();
            this.aButtonViewLogs = new System.Windows.Forms.Button();
            this.aLabelCompanyName = new System.Windows.Forms.Label();
            this.aTextBoxCompanyName = new System.Windows.Forms.TextBox();
            this.aCheckBoxUninstalled = new System.Windows.Forms.CheckBox();
            this.aCheckBoxDeleted = new System.Windows.Forms.CheckBox();
            this.aCheckBoxWillCancel = new System.Windows.Forms.CheckBox();
            this.aButtonRenewOneYear = new System.Windows.Forms.Button();
            this.aButtonCancelLicense = new System.Windows.Forms.Button();
            this.aCheckBoxAdvanced = new System.Windows.Forms.CheckBox();
            this.aButtonRenew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aTextBoxNotes
            // 
            this.aTextBoxNotes.AcceptsReturn = true;
            this.aTextBoxNotes.Location = new System.Drawing.Point(106, 244);
            this.aTextBoxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxNotes.Multiline = true;
            this.aTextBoxNotes.Name = "aTextBoxNotes";
            this.aTextBoxNotes.Size = new System.Drawing.Size(458, 225);
            this.aTextBoxNotes.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Notes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Renewal Status:";
            // 
            // aLabelActive
            // 
            this.aLabelActive.AutoSize = true;
            this.aLabelActive.Location = new System.Drawing.Point(55, 99);
            this.aLabelActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelActive.Name = "aLabelActive";
            this.aLabelActive.Size = new System.Drawing.Size(40, 13);
            this.aLabelActive.TabIndex = 30;
            this.aLabelActive.Text = "Active:";
            this.aLabelActive.Visible = false;
            // 
            // aLabelExpirationDate
            // 
            this.aLabelExpirationDate.AutoSize = true;
            this.aLabelExpirationDate.Location = new System.Drawing.Point(18, 153);
            this.aLabelExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelExpirationDate.Name = "aLabelExpirationDate";
            this.aLabelExpirationDate.Size = new System.Drawing.Size(82, 13);
            this.aLabelExpirationDate.TabIndex = 28;
            this.aLabelExpirationDate.Text = "Expiration Date:";
            // 
            // aTextBoxLastName
            // 
            this.aTextBoxLastName.Location = new System.Drawing.Point(107, 69);
            this.aTextBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxLastName.MaxLength = 50;
            this.aTextBoxLastName.Name = "aTextBoxLastName";
            this.aTextBoxLastName.ReadOnly = true;
            this.aTextBoxLastName.Size = new System.Drawing.Size(263, 20);
            this.aTextBoxLastName.TabIndex = 3;
            // 
            // aLabelFirstName
            // 
            this.aLabelFirstName.AutoSize = true;
            this.aLabelFirstName.Location = new System.Drawing.Point(40, 44);
            this.aLabelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelFirstName.Name = "aLabelFirstName";
            this.aLabelFirstName.Size = new System.Drawing.Size(60, 13);
            this.aLabelFirstName.TabIndex = 26;
            this.aLabelFirstName.Text = "First Name:";
            // 
            // aLabelLastName
            // 
            this.aLabelLastName.AutoSize = true;
            this.aLabelLastName.Location = new System.Drawing.Point(39, 72);
            this.aLabelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelLastName.Name = "aLabelLastName";
            this.aLabelLastName.Size = new System.Drawing.Size(61, 13);
            this.aLabelLastName.TabIndex = 25;
            this.aLabelLastName.Text = "Last Name:";
            // 
            // aTextBoxFirstName
            // 
            this.aTextBoxFirstName.Location = new System.Drawing.Point(107, 41);
            this.aTextBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxFirstName.MaxLength = 50;
            this.aTextBoxFirstName.Name = "aTextBoxFirstName";
            this.aTextBoxFirstName.ReadOnly = true;
            this.aTextBoxFirstName.Size = new System.Drawing.Size(263, 20);
            this.aTextBoxFirstName.TabIndex = 2;
            // 
            // aComboboxActive
            // 
            this.aComboboxActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxActive.FormattingEnabled = true;
            this.aComboboxActive.Items.AddRange(new object[] {
            "True",
            "False"});
            this.aComboboxActive.Location = new System.Drawing.Point(107, 96);
            this.aComboboxActive.Name = "aComboboxActive";
            this.aComboboxActive.Size = new System.Drawing.Size(121, 21);
            this.aComboboxActive.TabIndex = 7;
            this.aComboboxActive.Visible = false;
            // 
            // aComboboxRenewalStatus
            // 
            this.aComboboxRenewalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxRenewalStatus.FormattingEnabled = true;
            this.aComboboxRenewalStatus.Items.AddRange(new object[] {
            "Renewed",
            "Will Renew",
            "Pending",
            "Cancel Pending",
            "Cancelled",
            "Undefined"});
            this.aComboboxRenewalStatus.Location = new System.Drawing.Point(107, 176);
            this.aComboboxRenewalStatus.Name = "aComboboxRenewalStatus";
            this.aComboboxRenewalStatus.Size = new System.Drawing.Size(121, 21);
            this.aComboboxRenewalStatus.TabIndex = 8;
            this.aComboboxRenewalStatus.SelectedIndexChanged += new System.EventHandler(this.AComboboxRenewalStatus_SelectedIndexChanged);
            // 
            // aButtonSave
            // 
            this.aButtonSave.Location = new System.Drawing.Point(365, 510);
            this.aButtonSave.Name = "aButtonSave";
            this.aButtonSave.Size = new System.Drawing.Size(97, 40);
            this.aButtonSave.TabIndex = 11;
            this.aButtonSave.Text = "Save and Close";
            this.aButtonSave.UseVisualStyleBackColor = true;
            this.aButtonSave.Click += new System.EventHandler(this.aButtonSave_Click);
            // 
            // aButtonCancel
            // 
            this.aButtonCancel.Location = new System.Drawing.Point(468, 510);
            this.aButtonCancel.Name = "aButtonCancel";
            this.aButtonCancel.Size = new System.Drawing.Size(97, 40);
            this.aButtonCancel.TabIndex = 12;
            this.aButtonCancel.Text = "Close";
            this.aButtonCancel.UseVisualStyleBackColor = true;
            this.aButtonCancel.Click += new System.EventHandler(this.aButtonCancel_Click);
            // 
            // aComboboxReviewStatus
            // 
            this.aComboboxReviewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxReviewStatus.FormattingEnabled = true;
            this.aComboboxReviewStatus.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.aComboboxReviewStatus.Location = new System.Drawing.Point(107, 123);
            this.aComboboxReviewStatus.Name = "aComboboxReviewStatus";
            this.aComboboxReviewStatus.Size = new System.Drawing.Size(121, 21);
            this.aComboboxReviewStatus.TabIndex = 4;
            this.aComboboxReviewStatus.SelectedIndexChanged += new System.EventHandler(this.aComboboxReviewStatus_SelectedIndexChanged);
            // 
            // aLabelReviewStatus
            // 
            this.aLabelReviewStatus.AutoSize = true;
            this.aLabelReviewStatus.Location = new System.Drawing.Point(21, 126);
            this.aLabelReviewStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelReviewStatus.Name = "aLabelReviewStatus";
            this.aLabelReviewStatus.Size = new System.Drawing.Size(79, 13);
            this.aLabelReviewStatus.TabIndex = 56;
            this.aLabelReviewStatus.Text = "Review Status:";
            // 
            // aButtonAddYear
            // 
            this.aButtonAddYear.Location = new System.Drawing.Point(232, 149);
            this.aButtonAddYear.Name = "aButtonAddYear";
            this.aButtonAddYear.Size = new System.Drawing.Size(85, 20);
            this.aButtonAddYear.TabIndex = 6;
            this.aButtonAddYear.Text = "Add Year";
            this.aButtonAddYear.UseVisualStyleBackColor = true;
            this.aButtonAddYear.Click += new System.EventHandler(this.aButtonAddYear_Click);
            // 
            // aDateTimePickerExpirationDate
            // 
            this.aDateTimePickerExpirationDate.CustomFormat = "";
            this.aDateTimePickerExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePickerExpirationDate.Location = new System.Drawing.Point(107, 149);
            this.aDateTimePickerExpirationDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.aDateTimePickerExpirationDate.Name = "aDateTimePickerExpirationDate";
            this.aDateTimePickerExpirationDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aDateTimePickerExpirationDate.Size = new System.Drawing.Size(121, 20);
            this.aDateTimePickerExpirationDate.TabIndex = 5;
            // 
            // aLabelPCsLicensed
            // 
            this.aLabelPCsLicensed.AutoSize = true;
            this.aLabelPCsLicensed.Location = new System.Drawing.Point(23, 208);
            this.aLabelPCsLicensed.Name = "aLabelPCsLicensed";
            this.aLabelPCsLicensed.Size = new System.Drawing.Size(77, 13);
            this.aLabelPCsLicensed.TabIndex = 58;
            this.aLabelPCsLicensed.Text = "PC\'s Licensed:";
            // 
            // aButtonManagePCs
            // 
            this.aButtonManagePCs.Location = new System.Drawing.Point(232, 204);
            this.aButtonManagePCs.Name = "aButtonManagePCs";
            this.aButtonManagePCs.Size = new System.Drawing.Size(85, 21);
            this.aButtonManagePCs.TabIndex = 9;
            this.aButtonManagePCs.Text = "Manage PC\'s";
            this.aButtonManagePCs.UseVisualStyleBackColor = true;
            this.aButtonManagePCs.Click += new System.EventHandler(this.aButtonManagePCs_Click);
            // 
            // aLabelMachinesCount
            // 
            this.aLabelMachinesCount.AutoSize = true;
            this.aLabelMachinesCount.Location = new System.Drawing.Point(106, 208);
            this.aLabelMachinesCount.Name = "aLabelMachinesCount";
            this.aLabelMachinesCount.Size = new System.Drawing.Size(13, 13);
            this.aLabelMachinesCount.TabIndex = 61;
            this.aLabelMachinesCount.Text = "0";
            // 
            // aButtonViewLogs
            // 
            this.aButtonViewLogs.Location = new System.Drawing.Point(16, 525);
            this.aButtonViewLogs.Name = "aButtonViewLogs";
            this.aButtonViewLogs.Size = new System.Drawing.Size(75, 23);
            this.aButtonViewLogs.TabIndex = 62;
            this.aButtonViewLogs.Text = "View Logs";
            this.aButtonViewLogs.UseVisualStyleBackColor = true;
            this.aButtonViewLogs.Click += new System.EventHandler(this.aButtonViewLogs_Click);
            // 
            // aLabelCompanyName
            // 
            this.aLabelCompanyName.AutoSize = true;
            this.aLabelCompanyName.Location = new System.Drawing.Point(15, 16);
            this.aLabelCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelCompanyName.Name = "aLabelCompanyName";
            this.aLabelCompanyName.Size = new System.Drawing.Size(85, 13);
            this.aLabelCompanyName.TabIndex = 64;
            this.aLabelCompanyName.Text = "Company Name:";
            // 
            // aTextBoxCompanyName
            // 
            this.aTextBoxCompanyName.Location = new System.Drawing.Point(107, 13);
            this.aTextBoxCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxCompanyName.MaxLength = 50;
            this.aTextBoxCompanyName.Name = "aTextBoxCompanyName";
            this.aTextBoxCompanyName.ReadOnly = true;
            this.aTextBoxCompanyName.Size = new System.Drawing.Size(263, 20);
            this.aTextBoxCompanyName.TabIndex = 1;
            // 
            // aCheckBoxUninstalled
            // 
            this.aCheckBoxUninstalled.AutoSize = true;
            this.aCheckBoxUninstalled.Location = new System.Drawing.Point(342, 178);
            this.aCheckBoxUninstalled.Name = "aCheckBoxUninstalled";
            this.aCheckBoxUninstalled.Size = new System.Drawing.Size(78, 17);
            this.aCheckBoxUninstalled.TabIndex = 72;
            this.aCheckBoxUninstalled.Text = "Uninstalled";
            this.aCheckBoxUninstalled.UseVisualStyleBackColor = true;
            this.aCheckBoxUninstalled.Visible = false;
            // 
            // aCheckBoxDeleted
            // 
            this.aCheckBoxDeleted.AutoSize = true;
            this.aCheckBoxDeleted.Location = new System.Drawing.Point(426, 178);
            this.aCheckBoxDeleted.Name = "aCheckBoxDeleted";
            this.aCheckBoxDeleted.Size = new System.Drawing.Size(63, 17);
            this.aCheckBoxDeleted.TabIndex = 71;
            this.aCheckBoxDeleted.Text = "Deleted";
            this.aCheckBoxDeleted.UseVisualStyleBackColor = true;
            this.aCheckBoxDeleted.Visible = false;
            // 
            // aCheckBoxWillCancel
            // 
            this.aCheckBoxWillCancel.AutoSize = true;
            this.aCheckBoxWillCancel.Location = new System.Drawing.Point(253, 178);
            this.aCheckBoxWillCancel.Name = "aCheckBoxWillCancel";
            this.aCheckBoxWillCancel.Size = new System.Drawing.Size(85, 17);
            this.aCheckBoxWillCancel.TabIndex = 70;
            this.aCheckBoxWillCancel.Text = "Auto-Renew";
            this.aCheckBoxWillCancel.UseVisualStyleBackColor = true;
            // 
            // aButtonRenewOneYear
            // 
            this.aButtonRenewOneYear.Location = new System.Drawing.Point(106, 509);
            this.aButtonRenewOneYear.Name = "aButtonRenewOneYear";
            this.aButtonRenewOneYear.Size = new System.Drawing.Size(97, 41);
            this.aButtonRenewOneYear.TabIndex = 73;
            this.aButtonRenewOneYear.Text = "Renew 1 Yr";
            this.aButtonRenewOneYear.UseVisualStyleBackColor = true;
            this.aButtonRenewOneYear.Click += new System.EventHandler(this.AButtonRenewOneYear_Click);
            // 
            // aButtonCancelLicense
            // 
            this.aButtonCancelLicense.Location = new System.Drawing.Point(210, 510);
            this.aButtonCancelLicense.Name = "aButtonCancelLicense";
            this.aButtonCancelLicense.Size = new System.Drawing.Size(97, 40);
            this.aButtonCancelLicense.TabIndex = 74;
            this.aButtonCancelLicense.Text = "Cancel License";
            this.aButtonCancelLicense.UseVisualStyleBackColor = true;
            this.aButtonCancelLicense.Click += new System.EventHandler(this.AButtonCancelLicense_Click);
            // 
            // aCheckBoxAdvanced
            // 
            this.aCheckBoxAdvanced.AutoSize = true;
            this.aCheckBoxAdvanced.Location = new System.Drawing.Point(467, 12);
            this.aCheckBoxAdvanced.Name = "aCheckBoxAdvanced";
            this.aCheckBoxAdvanced.Size = new System.Drawing.Size(75, 17);
            this.aCheckBoxAdvanced.TabIndex = 75;
            this.aCheckBoxAdvanced.Text = "Advanced";
            this.aCheckBoxAdvanced.UseVisualStyleBackColor = true;
            this.aCheckBoxAdvanced.CheckStateChanged += new System.EventHandler(this.aCheckBoxAdvanced_CheckStateChanged);
            // 
            // aButtonRenew
            // 
            this.aButtonRenew.Location = new System.Drawing.Point(106, 476);
            this.aButtonRenew.Name = "aButtonRenew";
            this.aButtonRenew.Size = new System.Drawing.Size(97, 28);
            this.aButtonRenew.TabIndex = 76;
            this.aButtonRenew.Text = "Renew";
            this.aButtonRenew.UseVisualStyleBackColor = true;
            this.aButtonRenew.Click += new System.EventHandler(this.aButtonRenew_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 562);
            this.Controls.Add(this.aButtonRenew);
            this.Controls.Add(this.aCheckBoxAdvanced);
            this.Controls.Add(this.aButtonCancelLicense);
            this.Controls.Add(this.aButtonRenewOneYear);
            this.Controls.Add(this.aCheckBoxUninstalled);
            this.Controls.Add(this.aCheckBoxDeleted);
            this.Controls.Add(this.aCheckBoxWillCancel);
            this.Controls.Add(this.aLabelCompanyName);
            this.Controls.Add(this.aTextBoxCompanyName);
            this.Controls.Add(this.aButtonViewLogs);
            this.Controls.Add(this.aLabelMachinesCount);
            this.Controls.Add(this.aButtonManagePCs);
            this.Controls.Add(this.aLabelPCsLicensed);
            this.Controls.Add(this.aDateTimePickerExpirationDate);
            this.Controls.Add(this.aButtonAddYear);
            this.Controls.Add(this.aComboboxReviewStatus);
            this.Controls.Add(this.aLabelReviewStatus);
            this.Controls.Add(this.aButtonCancel);
            this.Controls.Add(this.aButtonSave);
            this.Controls.Add(this.aComboboxRenewalStatus);
            this.Controls.Add(this.aComboboxActive);
            this.Controls.Add(this.aTextBoxNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aLabelActive);
            this.Controls.Add(this.aLabelExpirationDate);
            this.Controls.Add(this.aTextBoxLastName);
            this.Controls.Add(this.aLabelFirstName);
            this.Controls.Add(this.aLabelLastName);
            this.Controls.Add(this.aTextBoxFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit License Information";
            this.Shown += new System.EventHandler(this.EditForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox aTextBoxNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aLabelActive;
        private System.Windows.Forms.Label aLabelExpirationDate;
        private System.Windows.Forms.TextBox aTextBoxLastName;
        private System.Windows.Forms.Label aLabelFirstName;
        private System.Windows.Forms.Label aLabelLastName;
        private System.Windows.Forms.TextBox aTextBoxFirstName;
        private System.Windows.Forms.ComboBox aComboboxActive;
        private System.Windows.Forms.ComboBox aComboboxRenewalStatus;
        private System.Windows.Forms.Button aButtonSave;
        private System.Windows.Forms.Button aButtonCancel;
        private System.Windows.Forms.Label aLabelReviewStatus;
        private System.Windows.Forms.Button aButtonAddYear;
        private System.Windows.Forms.DateTimePicker aDateTimePickerExpirationDate;
        private System.Windows.Forms.Label aLabelPCsLicensed;
        private System.Windows.Forms.Button aButtonManagePCs;
        private System.Windows.Forms.Label aLabelMachinesCount;
        private System.Windows.Forms.Button aButtonViewLogs;
        private System.Windows.Forms.Label aLabelCompanyName;
        private System.Windows.Forms.TextBox aTextBoxCompanyName;
        private System.Windows.Forms.ComboBox aComboboxReviewStatus;
        private System.Windows.Forms.CheckBox aCheckBoxUninstalled;
        private System.Windows.Forms.CheckBox aCheckBoxDeleted;
        private System.Windows.Forms.CheckBox aCheckBoxWillCancel;
        private System.Windows.Forms.Button aButtonRenewOneYear;
        private System.Windows.Forms.Button aButtonCancelLicense;
        private System.Windows.Forms.CheckBox aCheckBoxAdvanced;
        private System.Windows.Forms.Button aButtonRenew;
    }
}