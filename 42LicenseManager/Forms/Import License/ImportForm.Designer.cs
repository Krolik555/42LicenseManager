
namespace _42LicenseManager.Forms.Import_License
{
    partial class ImportForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aDGVFailed = new System.Windows.Forms.DataGridView();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLabelVerified = new System.Windows.Forms.Label();
            this.aLabelFailed = new System.Windows.Forms.Label();
            this.aLabelVerifiedCount = new System.Windows.Forms.Label();
            this.aLabelFailedCount = new System.Windows.Forms.Label();
            this.aButtonSubmit = new System.Windows.Forms.Button();
            this.aBtnBrowse = new System.Windows.Forms.Button();
            this.aTextBoxSource = new System.Windows.Forms.TextBox();
            this.aBtnAnalyze = new System.Windows.Forms.Button();
            this.aDGVVerified = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aTextBoxVerifiedNotes = new System.Windows.Forms.TextBox();
            this.aTextBoxFailedNotes = new System.Windows.Forms.TextBox();
            this.aComboboxFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aLinkLabelTemplate = new System.Windows.Forms.LinkLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.licenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renewalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aDGVFailed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDGVVerified)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aDGVFailed
            // 
            this.aDGVFailed.AllowUserToAddRows = false;
            this.aDGVFailed.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aDGVFailed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.aDGVFailed.AutoGenerateColumns = false;
            this.aDGVFailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDGVFailed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.reviewStatusDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.renewalStatusDataGridViewTextBoxColumn,
            this.pCCountDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.Notes});
            this.aDGVFailed.DataSource = this.licenseBindingSource;
            this.aDGVFailed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.aDGVFailed.Location = new System.Drawing.Point(12, 395);
            this.aDGVFailed.MultiSelect = false;
            this.aDGVFailed.Name = "aDGVFailed";
            this.aDGVFailed.ReadOnly = true;
            this.aDGVFailed.Size = new System.Drawing.Size(762, 226);
            this.aDGVFailed.TabIndex = 5;
            this.aDGVFailed.TabStop = false;
            this.aDGVFailed.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDGVFailed_CellEnter);
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Visible = false;
            // 
            // aLabelVerified
            // 
            this.aLabelVerified.AutoSize = true;
            this.aLabelVerified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelVerified.Location = new System.Drawing.Point(492, 117);
            this.aLabelVerified.Name = "aLabelVerified";
            this.aLabelVerified.Size = new System.Drawing.Size(71, 20);
            this.aLabelVerified.TabIndex = 6;
            this.aLabelVerified.Text = "Verified: ";
            // 
            // aLabelFailed
            // 
            this.aLabelFailed.AutoSize = true;
            this.aLabelFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelFailed.Location = new System.Drawing.Point(503, 372);
            this.aLabelFailed.Name = "aLabelFailed";
            this.aLabelFailed.Size = new System.Drawing.Size(60, 20);
            this.aLabelFailed.TabIndex = 7;
            this.aLabelFailed.Text = "Failed: ";
            // 
            // aLabelVerifiedCount
            // 
            this.aLabelVerifiedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelVerifiedCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.aLabelVerifiedCount.Location = new System.Drawing.Point(554, 117);
            this.aLabelVerifiedCount.Name = "aLabelVerifiedCount";
            this.aLabelVerifiedCount.Size = new System.Drawing.Size(195, 20);
            this.aLabelVerifiedCount.TabIndex = 8;
            this.aLabelVerifiedCount.Text = "0";
            // 
            // aLabelFailedCount
            // 
            this.aLabelFailedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelFailedCount.ForeColor = System.Drawing.Color.Firebrick;
            this.aLabelFailedCount.Location = new System.Drawing.Point(554, 372);
            this.aLabelFailedCount.Name = "aLabelFailedCount";
            this.aLabelFailedCount.Size = new System.Drawing.Size(189, 20);
            this.aLabelFailedCount.TabIndex = 9;
            this.aLabelFailedCount.Text = "0";
            // 
            // aButtonSubmit
            // 
            this.aButtonSubmit.Enabled = false;
            this.aButtonSubmit.Location = new System.Drawing.Point(1130, 76);
            this.aButtonSubmit.Name = "aButtonSubmit";
            this.aButtonSubmit.Size = new System.Drawing.Size(68, 54);
            this.aButtonSubmit.TabIndex = 10;
            this.aButtonSubmit.Text = "Submit to Database";
            this.aButtonSubmit.UseVisualStyleBackColor = true;
            this.aButtonSubmit.Click += new System.EventHandler(this.aButtonSubmit_Click);
            // 
            // aBtnBrowse
            // 
            this.aBtnBrowse.Enabled = false;
            this.aBtnBrowse.Location = new System.Drawing.Point(6, 19);
            this.aBtnBrowse.Name = "aBtnBrowse";
            this.aBtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.aBtnBrowse.TabIndex = 11;
            this.aBtnBrowse.Text = "Browse";
            this.aBtnBrowse.UseVisualStyleBackColor = true;
            this.aBtnBrowse.Click += new System.EventHandler(this.aBtnBrowse_Click);
            // 
            // aTextBoxSource
            // 
            this.aTextBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aTextBoxSource.Location = new System.Drawing.Point(86, 21);
            this.aTextBoxSource.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxSource.Name = "aTextBoxSource";
            this.aTextBoxSource.Size = new System.Drawing.Size(305, 20);
            this.aTextBoxSource.TabIndex = 12;
            // 
            // aBtnAnalyze
            // 
            this.aBtnAnalyze.Enabled = false;
            this.aBtnAnalyze.Location = new System.Drawing.Point(396, 19);
            this.aBtnAnalyze.Name = "aBtnAnalyze";
            this.aBtnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.aBtnAnalyze.TabIndex = 13;
            this.aBtnAnalyze.Text = "Analyze";
            this.aBtnAnalyze.UseVisualStyleBackColor = true;
            this.aBtnAnalyze.Click += new System.EventHandler(this.aBtnAnalyze_Click);
            // 
            // aDGVVerified
            // 
            this.aDGVVerified.AllowUserToAddRows = false;
            this.aDGVVerified.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aDGVVerified.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.aDGVVerified.AutoGenerateColumns = false;
            this.aDGVVerified.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDGVVerified.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9});
            this.aDGVVerified.DataSource = this.licenseBindingSource;
            this.aDGVVerified.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.aDGVVerified.Location = new System.Drawing.Point(12, 140);
            this.aDGVVerified.MultiSelect = false;
            this.aDGVVerified.Name = "aDGVVerified";
            this.aDGVVerified.ReadOnly = true;
            this.aDGVVerified.Size = new System.Drawing.Size(762, 226);
            this.aDGVVerified.TabIndex = 14;
            this.aDGVVerified.TabStop = false;
            this.aDGVVerified.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDGVVerified_CellEnter);
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn9.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aBtnBrowse);
            this.groupBox1.Controls.Add(this.aBtnAnalyze);
            this.groupBox1.Controls.Add(this.aTextBoxSource);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 50);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Import Data";
            // 
            // aTextBoxVerifiedNotes
            // 
            this.aTextBoxVerifiedNotes.AcceptsReturn = true;
            this.aTextBoxVerifiedNotes.Location = new System.Drawing.Point(799, 140);
            this.aTextBoxVerifiedNotes.Multiline = true;
            this.aTextBoxVerifiedNotes.Name = "aTextBoxVerifiedNotes";
            this.aTextBoxVerifiedNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aTextBoxVerifiedNotes.Size = new System.Drawing.Size(399, 223);
            this.aTextBoxVerifiedNotes.TabIndex = 16;
            // 
            // aTextBoxFailedNotes
            // 
            this.aTextBoxFailedNotes.AcceptsReturn = true;
            this.aTextBoxFailedNotes.Location = new System.Drawing.Point(799, 395);
            this.aTextBoxFailedNotes.Multiline = true;
            this.aTextBoxFailedNotes.Name = "aTextBoxFailedNotes";
            this.aTextBoxFailedNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aTextBoxFailedNotes.Size = new System.Drawing.Size(399, 223);
            this.aTextBoxFailedNotes.TabIndex = 17;
            // 
            // aComboboxFormat
            // 
            this.aComboboxFormat.FormattingEnabled = true;
            this.aComboboxFormat.Items.AddRange(new object[] {
            "Avast Business Cloud Care"});
            this.aComboboxFormat.Location = new System.Drawing.Point(74, 36);
            this.aComboboxFormat.Name = "aComboboxFormat";
            this.aComboboxFormat.Size = new System.Drawing.Size(208, 21);
            this.aComboboxFormat.TabIndex = 19;
            this.aComboboxFormat.SelectionChangeCommitted += new System.EventHandler(this.aComboboxFormat_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Format:";
            // 
            // aLinkLabelTemplate
            // 
            this.aLinkLabelTemplate.AutoSize = true;
            this.aLinkLabelTemplate.Location = new System.Drawing.Point(289, 43);
            this.aLinkLabelTemplate.Name = "aLinkLabelTemplate";
            this.aLinkLabelTemplate.Size = new System.Drawing.Size(51, 13);
            this.aLinkLabelTemplate.TabIndex = 21;
            this.aLinkLabelTemplate.TabStop = true;
            this.aLinkLabelTemplate.Text = "Template";
            this.aLinkLabelTemplate.Visible = false;
            this.aLinkLabelTemplate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aLinkLabelTemplate_LinkClicked);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ReviewStatus";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn2.HeaderText = "Review Status";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CompanyName";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle14.Format = "N0";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn3.HeaderText = "Company Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 230;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FirstName";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle15.Format = "N0";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn4.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 190;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "LastName";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle16.Format = "N0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn5.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 190;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ExpirationDate";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn6.HeaderText = "Expiration Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RenewalStatus";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle18.Format = "N0";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn7.HeaderText = "Renewal Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 115;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PCCount";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle19.Format = "N0";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn8.HeaderText = "PC Count";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Active";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = false;
            this.dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // licenseBindingSource
            // 
            this.licenseBindingSource.DataSource = typeof(_42LicenseManager.License);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 75;
            // 
            // reviewStatusDataGridViewTextBoxColumn
            // 
            this.reviewStatusDataGridViewTextBoxColumn.DataPropertyName = "ReviewStatus";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.reviewStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.reviewStatusDataGridViewTextBoxColumn.HeaderText = "Review Status";
            this.reviewStatusDataGridViewTextBoxColumn.Name = "reviewStatusDataGridViewTextBoxColumn";
            this.reviewStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.reviewStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.Format = "N0";
            this.companyNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn.Width = 230;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.Format = "N0";
            this.firstNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 190;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.Format = "N0";
            this.lastNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 190;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.NullValue = null;
            this.expirationDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "Expiration Date";
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            this.expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expirationDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // renewalStatusDataGridViewTextBoxColumn
            // 
            this.renewalStatusDataGridViewTextBoxColumn.DataPropertyName = "RenewalStatus";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle8.Format = "N0";
            this.renewalStatusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.renewalStatusDataGridViewTextBoxColumn.HeaderText = "Renewal Status";
            this.renewalStatusDataGridViewTextBoxColumn.Name = "renewalStatusDataGridViewTextBoxColumn";
            this.renewalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.renewalStatusDataGridViewTextBoxColumn.Visible = false;
            this.renewalStatusDataGridViewTextBoxColumn.Width = 115;
            // 
            // pCCountDataGridViewTextBoxColumn
            // 
            this.pCCountDataGridViewTextBoxColumn.DataPropertyName = "PCCount";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.Format = "N0";
            this.pCCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.pCCountDataGridViewTextBoxColumn.HeaderText = "PC Count";
            this.pCCountDataGridViewTextBoxColumn.Name = "pCCountDataGridViewTextBoxColumn";
            this.pCCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCCountDataGridViewTextBoxColumn.Visible = false;
            this.pCCountDataGridViewTextBoxColumn.Width = 75;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = false;
            this.activeDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Visible = false;
            this.activeDataGridViewCheckBoxColumn.Width = 60;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 666);
            this.Controls.Add(this.aLinkLabelTemplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aComboboxFormat);
            this.Controls.Add(this.aTextBoxFailedNotes);
            this.Controls.Add(this.aTextBoxVerifiedNotes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aDGVVerified);
            this.Controls.Add(this.aButtonSubmit);
            this.Controls.Add(this.aLabelFailedCount);
            this.Controls.Add(this.aLabelVerifiedCount);
            this.Controls.Add(this.aLabelFailed);
            this.Controls.Add(this.aLabelVerified);
            this.Controls.Add(this.aDGVFailed);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import License";
            ((System.ComponentModel.ISupportInitialize)(this.aDGVFailed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDGVVerified)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aDGVFailed;
        private System.Windows.Forms.BindingSource licenseBindingSource;
        private System.Windows.Forms.Label aLabelVerified;
        private System.Windows.Forms.Label aLabelFailed;
        private System.Windows.Forms.Label aLabelVerifiedCount;
        private System.Windows.Forms.Label aLabelFailedCount;
        private System.Windows.Forms.Button aButtonSubmit;
        private System.Windows.Forms.Button aBtnBrowse;
        private System.Windows.Forms.TextBox aTextBoxSource;
        private System.Windows.Forms.Button aBtnAnalyze;
        private System.Windows.Forms.DataGridView aDGVVerified;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox aTextBoxVerifiedNotes;
        private System.Windows.Forms.TextBox aTextBoxFailedNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renewalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox aComboboxFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel aLinkLabelTemplate;
    }
}