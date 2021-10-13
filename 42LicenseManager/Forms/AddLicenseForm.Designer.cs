namespace _42LicenseManager
{
    partial class AddLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLicenseForm));
            this.aButtonCancel = new System.Windows.Forms.Button();
            this.aButtonSave = new System.Windows.Forms.Button();
            this.aComboboxRenewalStatus = new System.Windows.Forms.ComboBox();
            this.aComboboxActive = new System.Windows.Forms.ComboBox();
            this.aLabelEditCustomerInfo = new System.Windows.Forms.Label();
            this.aTextBoxNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aLabelActive = new System.Windows.Forms.Label();
            this.aLabelExpirationDate = new System.Windows.Forms.Label();
            this.aTextBoxLastName = new System.Windows.Forms.TextBox();
            this.aLabelFirstName = new System.Windows.Forms.Label();
            this.aLabelLastName = new System.Windows.Forms.Label();
            this.aTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.aLabelReviewStatus = new System.Windows.Forms.Label();
            this.aComboboxReviewStatus = new System.Windows.Forms.ComboBox();
            this.aDateTimePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.aButtonAddYear = new System.Windows.Forms.Button();
            this.aButtonTest = new System.Windows.Forms.Button();
            this.aLabelHelper = new System.Windows.Forms.Label();
            this.aButtonSaveAddMachines = new System.Windows.Forms.Button();
            this.aLabelCompanyName = new System.Windows.Forms.Label();
            this.aTextBoxCompanyName = new System.Windows.Forms.TextBox();
            this.aCheckBoxAdvanced = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // aButtonCancel
            // 
            this.aButtonCancel.Location = new System.Drawing.Point(464, 497);
            this.aButtonCancel.Name = "aButtonCancel";
            this.aButtonCancel.Size = new System.Drawing.Size(97, 41);
            this.aButtonCancel.TabIndex = 12;
            this.aButtonCancel.Text = "Cancel";
            this.aButtonCancel.UseVisualStyleBackColor = true;
            this.aButtonCancel.Click += new System.EventHandler(this.aButtonCancel_Click);
            // 
            // aButtonSave
            // 
            this.aButtonSave.Location = new System.Drawing.Point(361, 497);
            this.aButtonSave.Name = "aButtonSave";
            this.aButtonSave.Size = new System.Drawing.Size(97, 41);
            this.aButtonSave.TabIndex = 11;
            this.aButtonSave.Text = "Save and Close";
            this.aButtonSave.UseVisualStyleBackColor = true;
            this.aButtonSave.Click += new System.EventHandler(this.aButtonSave_Click);
            // 
            // aComboboxRenewalStatus
            // 
            this.aComboboxRenewalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxRenewalStatus.Enabled = false;
            this.aComboboxRenewalStatus.FormattingEnabled = true;
            this.aComboboxRenewalStatus.Items.AddRange(new object[] {
            "Renewed",
            "Will Renew",
            "Pending",
            "Cancel Pending",
            "Cancelled",
            "Undefined"});
            this.aComboboxRenewalStatus.Location = new System.Drawing.Point(103, 228);
            this.aComboboxRenewalStatus.Name = "aComboboxRenewalStatus";
            this.aComboboxRenewalStatus.Size = new System.Drawing.Size(121, 21);
            this.aComboboxRenewalStatus.TabIndex = 8;
            // 
            // aComboboxActive
            // 
            this.aComboboxActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxActive.Enabled = false;
            this.aComboboxActive.FormattingEnabled = true;
            this.aComboboxActive.Items.AddRange(new object[] {
            "True",
            "False"});
            this.aComboboxActive.Location = new System.Drawing.Point(103, 201);
            this.aComboboxActive.Name = "aComboboxActive";
            this.aComboboxActive.Size = new System.Drawing.Size(121, 21);
            this.aComboboxActive.TabIndex = 7;
            this.aComboboxActive.SelectedIndexChanged += new System.EventHandler(this.aComboboxActive_SelectedIndexChanged);
            // 
            // aLabelEditCustomerInfo
            // 
            this.aLabelEditCustomerInfo.AutoSize = true;
            this.aLabelEditCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelEditCustomerInfo.Location = new System.Drawing.Point(208, 18);
            this.aLabelEditCustomerInfo.Name = "aLabelEditCustomerInfo";
            this.aLabelEditCustomerInfo.Size = new System.Drawing.Size(182, 26);
            this.aLabelEditCustomerInfo.TabIndex = 49;
            this.aLabelEditCustomerInfo.Text = "Add New License";
            // 
            // aTextBoxNotes
            // 
            this.aTextBoxNotes.AcceptsReturn = true;
            this.aTextBoxNotes.Location = new System.Drawing.Point(103, 256);
            this.aTextBoxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxNotes.Multiline = true;
            this.aTextBoxNotes.Name = "aTextBoxNotes";
            this.aTextBoxNotes.Size = new System.Drawing.Size(458, 234);
            this.aTextBoxNotes.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Notes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Renewal Status:";
            // 
            // aLabelActive
            // 
            this.aLabelActive.AutoSize = true;
            this.aLabelActive.Location = new System.Drawing.Point(15, 204);
            this.aLabelActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelActive.Name = "aLabelActive";
            this.aLabelActive.Size = new System.Drawing.Size(80, 13);
            this.aLabelActive.TabIndex = 45;
            this.aLabelActive.Text = "License Active:";
            // 
            // aLabelExpirationDate
            // 
            this.aLabelExpirationDate.AutoSize = true;
            this.aLabelExpirationDate.Location = new System.Drawing.Point(13, 152);
            this.aLabelExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelExpirationDate.Name = "aLabelExpirationDate";
            this.aLabelExpirationDate.Size = new System.Drawing.Size(82, 13);
            this.aLabelExpirationDate.TabIndex = 43;
            this.aLabelExpirationDate.Text = "Expiration Date:";
            // 
            // aTextBoxLastName
            // 
            this.aTextBoxLastName.Location = new System.Drawing.Point(103, 121);
            this.aTextBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxLastName.MaxLength = 50;
            this.aTextBoxLastName.Name = "aTextBoxLastName";
            this.aTextBoxLastName.Size = new System.Drawing.Size(264, 20);
            this.aTextBoxLastName.TabIndex = 3;
            this.aTextBoxLastName.TextChanged += new System.EventHandler(this.aTextBoxLastName_TextChanged);
            // 
            // aLabelFirstName
            // 
            this.aLabelFirstName.AutoSize = true;
            this.aLabelFirstName.Location = new System.Drawing.Point(35, 97);
            this.aLabelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelFirstName.Name = "aLabelFirstName";
            this.aLabelFirstName.Size = new System.Drawing.Size(60, 13);
            this.aLabelFirstName.TabIndex = 41;
            this.aLabelFirstName.Text = "First Name:";
            // 
            // aLabelLastName
            // 
            this.aLabelLastName.AutoSize = true;
            this.aLabelLastName.Location = new System.Drawing.Point(34, 124);
            this.aLabelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelLastName.Name = "aLabelLastName";
            this.aLabelLastName.Size = new System.Drawing.Size(61, 13);
            this.aLabelLastName.TabIndex = 40;
            this.aLabelLastName.Text = "Last Name:";
            // 
            // aTextBoxFirstName
            // 
            this.aTextBoxFirstName.Location = new System.Drawing.Point(103, 93);
            this.aTextBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxFirstName.MaxLength = 50;
            this.aTextBoxFirstName.Name = "aTextBoxFirstName";
            this.aTextBoxFirstName.Size = new System.Drawing.Size(264, 20);
            this.aTextBoxFirstName.TabIndex = 2;
            this.aTextBoxFirstName.TextChanged += new System.EventHandler(this.aTextBoxFirstName_TextChanged);
            // 
            // aLabelReviewStatus
            // 
            this.aLabelReviewStatus.AutoSize = true;
            this.aLabelReviewStatus.Location = new System.Drawing.Point(16, 177);
            this.aLabelReviewStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelReviewStatus.Name = "aLabelReviewStatus";
            this.aLabelReviewStatus.Size = new System.Drawing.Size(79, 13);
            this.aLabelReviewStatus.TabIndex = 54;
            this.aLabelReviewStatus.Text = "Review Status:";
            // 
            // aComboboxReviewStatus
            // 
            this.aComboboxReviewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxReviewStatus.Enabled = false;
            this.aComboboxReviewStatus.FormattingEnabled = true;
            this.aComboboxReviewStatus.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.aComboboxReviewStatus.Location = new System.Drawing.Point(103, 174);
            this.aComboboxReviewStatus.Name = "aComboboxReviewStatus";
            this.aComboboxReviewStatus.Size = new System.Drawing.Size(121, 21);
            this.aComboboxReviewStatus.TabIndex = 4;
            this.aComboboxReviewStatus.SelectedIndexChanged += new System.EventHandler(this.aComboboxReviewStatus_SelectedIndexChanged);
            // 
            // aDateTimePickerExpirationDate
            // 
            this.aDateTimePickerExpirationDate.CustomFormat = "";
            this.aDateTimePickerExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePickerExpirationDate.Location = new System.Drawing.Point(103, 148);
            this.aDateTimePickerExpirationDate.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.aDateTimePickerExpirationDate.Name = "aDateTimePickerExpirationDate";
            this.aDateTimePickerExpirationDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aDateTimePickerExpirationDate.Size = new System.Drawing.Size(121, 20);
            this.aDateTimePickerExpirationDate.TabIndex = 5;
            // 
            // aButtonAddYear
            // 
            this.aButtonAddYear.Location = new System.Drawing.Point(230, 148);
            this.aButtonAddYear.Name = "aButtonAddYear";
            this.aButtonAddYear.Size = new System.Drawing.Size(75, 20);
            this.aButtonAddYear.TabIndex = 6;
            this.aButtonAddYear.Text = "Add Year";
            this.aButtonAddYear.UseVisualStyleBackColor = true;
            this.aButtonAddYear.Click += new System.EventHandler(this.aButtonAddYear_Click);
            // 
            // aButtonTest
            // 
            this.aButtonTest.Location = new System.Drawing.Point(8, 497);
            this.aButtonTest.Name = "aButtonTest";
            this.aButtonTest.Size = new System.Drawing.Size(75, 23);
            this.aButtonTest.TabIndex = 57;
            this.aButtonTest.TabStop = false;
            this.aButtonTest.Text = "Test";
            this.aButtonTest.UseVisualStyleBackColor = true;
            this.aButtonTest.Visible = false;
            this.aButtonTest.Click += new System.EventHandler(this.aButtonTest_Click);
            // 
            // aLabelHelper
            // 
            this.aLabelHelper.AutoSize = true;
            this.aLabelHelper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelHelper.Location = new System.Drawing.Point(227, 231);
            this.aLabelHelper.Name = "aLabelHelper";
            this.aLabelHelper.Size = new System.Drawing.Size(218, 13);
            this.aLabelHelper.TabIndex = 58;
            this.aLabelHelper.Text = "- \"Renewed\" recommended for new licenses";
            this.aLabelHelper.Visible = false;
            // 
            // aButtonSaveAddMachines
            // 
            this.aButtonSaveAddMachines.Location = new System.Drawing.Point(258, 497);
            this.aButtonSaveAddMachines.Name = "aButtonSaveAddMachines";
            this.aButtonSaveAddMachines.Size = new System.Drawing.Size(97, 41);
            this.aButtonSaveAddMachines.TabIndex = 10;
            this.aButtonSaveAddMachines.Text = "Save and Add Machines";
            this.aButtonSaveAddMachines.UseVisualStyleBackColor = true;
            this.aButtonSaveAddMachines.Click += new System.EventHandler(this.aButtonSaveAddMachines_Click);
            // 
            // aLabelCompanyName
            // 
            this.aLabelCompanyName.AutoSize = true;
            this.aLabelCompanyName.Location = new System.Drawing.Point(10, 69);
            this.aLabelCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelCompanyName.Name = "aLabelCompanyName";
            this.aLabelCompanyName.Size = new System.Drawing.Size(85, 13);
            this.aLabelCompanyName.TabIndex = 60;
            this.aLabelCompanyName.Text = "Company Name:";
            // 
            // aTextBoxCompanyName
            // 
            this.aTextBoxCompanyName.Location = new System.Drawing.Point(103, 66);
            this.aTextBoxCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxCompanyName.MaxLength = 50;
            this.aTextBoxCompanyName.Name = "aTextBoxCompanyName";
            this.aTextBoxCompanyName.Size = new System.Drawing.Size(390, 20);
            this.aTextBoxCompanyName.TabIndex = 1;
            // 
            // aCheckBoxAdvanced
            // 
            this.aCheckBoxAdvanced.AutoSize = true;
            this.aCheckBoxAdvanced.Location = new System.Drawing.Point(230, 205);
            this.aCheckBoxAdvanced.Name = "aCheckBoxAdvanced";
            this.aCheckBoxAdvanced.Size = new System.Drawing.Size(75, 17);
            this.aCheckBoxAdvanced.TabIndex = 61;
            this.aCheckBoxAdvanced.Text = "Advanced";
            this.aCheckBoxAdvanced.UseVisualStyleBackColor = true;
            this.aCheckBoxAdvanced.CheckedChanged += new System.EventHandler(this.ACheckBoxAdvanced_CheckedChanged);
            // 
            // AddLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 549);
            this.Controls.Add(this.aCheckBoxAdvanced);
            this.Controls.Add(this.aLabelCompanyName);
            this.Controls.Add(this.aTextBoxCompanyName);
            this.Controls.Add(this.aButtonSaveAddMachines);
            this.Controls.Add(this.aLabelHelper);
            this.Controls.Add(this.aButtonTest);
            this.Controls.Add(this.aButtonAddYear);
            this.Controls.Add(this.aDateTimePickerExpirationDate);
            this.Controls.Add(this.aComboboxReviewStatus);
            this.Controls.Add(this.aLabelReviewStatus);
            this.Controls.Add(this.aButtonCancel);
            this.Controls.Add(this.aButtonSave);
            this.Controls.Add(this.aComboboxRenewalStatus);
            this.Controls.Add(this.aComboboxActive);
            this.Controls.Add(this.aLabelEditCustomerInfo);
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
            this.Name = "AddLicenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add License Form";
            this.Shown += new System.EventHandler(this.AddLicenseForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aButtonCancel;
        private System.Windows.Forms.Button aButtonSave;
        private System.Windows.Forms.ComboBox aComboboxRenewalStatus;
        private System.Windows.Forms.ComboBox aComboboxActive;
        private System.Windows.Forms.Label aLabelEditCustomerInfo;
        private System.Windows.Forms.TextBox aTextBoxNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aLabelActive;
        private System.Windows.Forms.Label aLabelExpirationDate;
        private System.Windows.Forms.TextBox aTextBoxLastName;
        private System.Windows.Forms.Label aLabelFirstName;
        private System.Windows.Forms.Label aLabelLastName;
        private System.Windows.Forms.TextBox aTextBoxFirstName;
        private System.Windows.Forms.Label aLabelReviewStatus;
        private System.Windows.Forms.ComboBox aComboboxReviewStatus;
        private System.Windows.Forms.DateTimePicker aDateTimePickerExpirationDate;
        private System.Windows.Forms.Button aButtonAddYear;
        private System.Windows.Forms.Button aButtonTest;
        private System.Windows.Forms.Label aLabelHelper;
        private System.Windows.Forms.Button aButtonSaveAddMachines;
        private System.Windows.Forms.Label aLabelCompanyName;
        private System.Windows.Forms.TextBox aTextBoxCompanyName;
        private System.Windows.Forms.CheckBox aCheckBoxAdvanced;
    }
}