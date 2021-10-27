namespace _42LicenseManager
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.aLabelSearch = new System.Windows.Forms.Label();
            this.aButtonEdit = new System.Windows.Forms.Button();
            this.aDataGridViewLicenses = new System.Windows.Forms.DataGridView();
            this.aComboboxSortBy = new System.Windows.Forms.ComboBox();
            this.aTextBoxSearch = new System.Windows.Forms.TextBox();
            this.aButtonTest = new System.Windows.Forms.Button();
            this.aButtonAddLicense = new System.Windows.Forms.Button();
            this.aButtonDelete = new System.Windows.Forms.Button();
            this.aLabelLicenseFoundLabel = new System.Windows.Forms.Label();
            this.aLabelLicenseFoundInt = new System.Windows.Forms.Label();
            this.aButtonCheckForExpires = new System.Windows.Forms.Button();
            this.aToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aButtonViewAllLogs = new System.Windows.Forms.Button();
            this.aLabelView = new System.Windows.Forms.Label();
            this.aStatusStripDashboard = new System.Windows.Forms.StatusStrip();
            this.backgroundWorkerBackup = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerAutoBackup = new System.ComponentModel.BackgroundWorker();
            this.aButtonRefresh = new System.Windows.Forms.Button();
            this.aButtonSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aCheckBoxAutoRenew = new System.Windows.Forms.CheckBox();
            this.aTextBoxNotes = new System.Windows.Forms.TextBox();
            this.licenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renewalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChkBxAutoRenew = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewLicenses)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabelSearch
            // 
            this.aLabelSearch.AutoSize = true;
            this.aLabelSearch.Enabled = false;
            this.aLabelSearch.Location = new System.Drawing.Point(413, 90);
            this.aLabelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelSearch.Name = "aLabelSearch";
            this.aLabelSearch.Size = new System.Drawing.Size(57, 17);
            this.aLabelSearch.TabIndex = 3;
            this.aLabelSearch.Text = "Search:";
            // 
            // aButtonEdit
            // 
            this.aButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonEdit.Location = new System.Drawing.Point(1197, 123);
            this.aButtonEdit.Name = "aButtonEdit";
            this.aButtonEdit.Size = new System.Drawing.Size(99, 37);
            this.aButtonEdit.TabIndex = 5;
            this.aButtonEdit.Text = "Edit License";
            this.aButtonEdit.UseVisualStyleBackColor = true;
            this.aButtonEdit.Click += new System.EventHandler(this.aButtonEdit_Click);
            // 
            // aDataGridViewLicenses
            // 
            this.aDataGridViewLicenses.AllowUserToAddRows = false;
            this.aDataGridViewLicenses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aDataGridViewLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.aDataGridViewLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridViewLicenses.AutoGenerateColumns = false;
            this.aDataGridViewLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridViewLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ReviewStatus,
            this.companyNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.renewalStatusDataGridViewTextBoxColumn,
            this.pCCountDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.ChkBxAutoRenew});
            this.aDataGridViewLicenses.DataSource = this.licenseBindingSource;
            this.aDataGridViewLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.aDataGridViewLicenses.Location = new System.Drawing.Point(14, 120);
            this.aDataGridViewLicenses.MultiSelect = false;
            this.aDataGridViewLicenses.Name = "aDataGridViewLicenses";
            this.aDataGridViewLicenses.ReadOnly = true;
            this.aDataGridViewLicenses.Size = new System.Drawing.Size(1177, 317);
            this.aDataGridViewLicenses.TabIndex = 4;
            this.aDataGridViewLicenses.TabStop = false;
            this.aDataGridViewLicenses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDataGridViewLicenses_CellDoubleClick);
            this.aDataGridViewLicenses.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDataGridViewLicenses_CellEnter);
            this.aDataGridViewLicenses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.aDataGridViewLicenses_CellFormatting);
            // 
            // aComboboxSortBy
            // 
            this.aComboboxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxSortBy.FormattingEnabled = true;
            this.aComboboxSortBy.Items.AddRange(new object[] {
            "Opened Licenses",
            "Search by Name\\Id",
            "Search by Machine Name",
            "All Licenses"});
            this.aComboboxSortBy.Location = new System.Drawing.Point(478, 56);
            this.aComboboxSortBy.Name = "aComboboxSortBy";
            this.aComboboxSortBy.Size = new System.Drawing.Size(189, 24);
            this.aComboboxSortBy.TabIndex = 1;
            this.aComboboxSortBy.SelectedIndexChanged += new System.EventHandler(this.aComboboxSortBy_SelectedIndexChanged);
            // 
            // aTextBoxSearch
            // 
            this.aTextBoxSearch.Enabled = false;
            this.aTextBoxSearch.Location = new System.Drawing.Point(478, 87);
            this.aTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxSearch.Name = "aTextBoxSearch";
            this.aTextBoxSearch.Size = new System.Drawing.Size(305, 23);
            this.aTextBoxSearch.TabIndex = 3;
            this.aTextBoxSearch.TextChanged += new System.EventHandler(this.ATextBoxSearch_TextChanged);
            this.aTextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ATextBoxSearch_KeyDown);
            this.aTextBoxSearch.Leave += new System.EventHandler(this.ATextBoxSearch_Leave);
            // 
            // aButtonTest
            // 
            this.aButtonTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonTest.Location = new System.Drawing.Point(1220, 475);
            this.aButtonTest.Name = "aButtonTest";
            this.aButtonTest.Size = new System.Drawing.Size(75, 68);
            this.aButtonTest.TabIndex = 27;
            this.aButtonTest.TabStop = false;
            this.aButtonTest.Text = "Test";
            this.aButtonTest.UseVisualStyleBackColor = true;
            this.aButtonTest.Visible = false;
            this.aButtonTest.Click += new System.EventHandler(this.aButtonTest_Click);
            // 
            // aButtonAddLicense
            // 
            this.aButtonAddLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonAddLicense.Location = new System.Drawing.Point(1197, 166);
            this.aButtonAddLicense.Name = "aButtonAddLicense";
            this.aButtonAddLicense.Size = new System.Drawing.Size(99, 37);
            this.aButtonAddLicense.TabIndex = 6;
            this.aButtonAddLicense.Text = "Add License";
            this.aButtonAddLicense.UseVisualStyleBackColor = true;
            this.aButtonAddLicense.Click += new System.EventHandler(this.aButtonAddLicense_Click);
            // 
            // aButtonDelete
            // 
            this.aButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonDelete.Location = new System.Drawing.Point(1197, 299);
            this.aButtonDelete.Name = "aButtonDelete";
            this.aButtonDelete.Size = new System.Drawing.Size(99, 37);
            this.aButtonDelete.TabIndex = 7;
            this.aButtonDelete.Text = "Delete";
            this.aButtonDelete.UseVisualStyleBackColor = true;
            this.aButtonDelete.Click += new System.EventHandler(this.aButtonDelete_Click);
            // 
            // aLabelLicenseFoundLabel
            // 
            this.aLabelLicenseFoundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabelLicenseFoundLabel.Location = new System.Drawing.Point(1083, 97);
            this.aLabelLicenseFoundLabel.Name = "aLabelLicenseFoundLabel";
            this.aLabelLicenseFoundLabel.Size = new System.Drawing.Size(68, 17);
            this.aLabelLicenseFoundLabel.TabIndex = 30;
            this.aLabelLicenseFoundLabel.Text = "Showing:";
            // 
            // aLabelLicenseFoundInt
            // 
            this.aLabelLicenseFoundInt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabelLicenseFoundInt.AutoSize = true;
            this.aLabelLicenseFoundInt.Location = new System.Drawing.Point(1148, 97);
            this.aLabelLicenseFoundInt.Name = "aLabelLicenseFoundInt";
            this.aLabelLicenseFoundInt.Size = new System.Drawing.Size(16, 17);
            this.aLabelLicenseFoundInt.TabIndex = 31;
            this.aLabelLicenseFoundInt.Text = "0";
            // 
            // aButtonCheckForExpires
            // 
            this.aButtonCheckForExpires.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonCheckForExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButtonCheckForExpires.Location = new System.Drawing.Point(1197, 210);
            this.aButtonCheckForExpires.Name = "aButtonCheckForExpires";
            this.aButtonCheckForExpires.Size = new System.Drawing.Size(99, 46);
            this.aButtonCheckForExpires.TabIndex = 4;
            this.aButtonCheckForExpires.Text = "Check for Expiring Licenses";
            this.aToolTip.SetToolTip(this.aButtonCheckForExpires, "Haven\'t restarted the program within the last day? \r\nThis will update licenses th" +
        "at expire within 21 days \r\nfrom today and set them to \'Open\'.");
            this.aButtonCheckForExpires.UseVisualStyleBackColor = true;
            this.aButtonCheckForExpires.Click += new System.EventHandler(this.aButtonCheckForExpires_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupNowToolStripMenuItem,
            this.selectDatabaseToolStripMenuItem,
            this.importLicensesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // backupNowToolStripMenuItem
            // 
            this.backupNowToolStripMenuItem.Name = "backupNowToolStripMenuItem";
            this.backupNowToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.backupNowToolStripMenuItem.Text = "Backup Now";
            this.backupNowToolStripMenuItem.Click += new System.EventHandler(this.backupNowToolStripMenuItem_Click);
            // 
            // selectDatabaseToolStripMenuItem
            // 
            this.selectDatabaseToolStripMenuItem.Name = "selectDatabaseToolStripMenuItem";
            this.selectDatabaseToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.selectDatabaseToolStripMenuItem.Text = "Select Database";
            this.selectDatabaseToolStripMenuItem.Click += new System.EventHandler(this.selectDatabaseToolStripMenuItem_Click);
            // 
            // importLicensesToolStripMenuItem
            // 
            this.importLicensesToolStripMenuItem.Name = "importLicensesToolStripMenuItem";
            this.importLicensesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.importLicensesToolStripMenuItem.Text = "Import Licenses";
            this.importLicensesToolStripMenuItem.Click += new System.EventHandler(this.importLicensesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDatabaseToolStripMenuItem,
            this.configureBackupToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // setDatabaseToolStripMenuItem
            // 
            this.setDatabaseToolStripMenuItem.Name = "setDatabaseToolStripMenuItem";
            this.setDatabaseToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.setDatabaseToolStripMenuItem.Text = "Configure Database";
            this.setDatabaseToolStripMenuItem.Click += new System.EventHandler(this.setDatabaseToolStripMenuItem_Click);
            // 
            // configureBackupToolStripMenuItem
            // 
            this.configureBackupToolStripMenuItem.Name = "configureBackupToolStripMenuItem";
            this.configureBackupToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.configureBackupToolStripMenuItem.Text = "Configure Backup";
            this.configureBackupToolStripMenuItem.Click += new System.EventHandler(this.configureBackupToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Visible = false;
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aButtonViewAllLogs
            // 
            this.aButtonViewAllLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonViewAllLogs.Location = new System.Drawing.Point(1197, 342);
            this.aButtonViewAllLogs.Name = "aButtonViewAllLogs";
            this.aButtonViewAllLogs.Size = new System.Drawing.Size(99, 37);
            this.aButtonViewAllLogs.TabIndex = 8;
            this.aButtonViewAllLogs.Text = "View All Logs";
            this.aButtonViewAllLogs.UseVisualStyleBackColor = true;
            this.aButtonViewAllLogs.Click += new System.EventHandler(this.aButtonViewAllLogs_Click);
            // 
            // aLabelView
            // 
            this.aLabelView.AutoSize = true;
            this.aLabelView.Location = new System.Drawing.Point(429, 56);
            this.aLabelView.Name = "aLabelView";
            this.aLabelView.Size = new System.Drawing.Size(41, 17);
            this.aLabelView.TabIndex = 34;
            this.aLabelView.Text = "View:";
            // 
            // aStatusStripDashboard
            // 
            this.aStatusStripDashboard.Location = new System.Drawing.Point(0, 594);
            this.aStatusStripDashboard.Name = "aStatusStripDashboard";
            this.aStatusStripDashboard.Size = new System.Drawing.Size(1307, 22);
            this.aStatusStripDashboard.TabIndex = 36;
            this.aStatusStripDashboard.Text = "statusStrip1";
            // 
            // backgroundWorkerBackup
            // 
            this.backgroundWorkerBackup.WorkerReportsProgress = true;
            this.backgroundWorkerBackup.WorkerSupportsCancellation = true;
            this.backgroundWorkerBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerBackup_DoWork);
            this.backgroundWorkerBackup.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerBackup_ProgressChanged);
            this.backgroundWorkerBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerBackup_RunWorkerCompleted);
            // 
            // backgroundWorkerAutoBackup
            // 
            this.backgroundWorkerAutoBackup.WorkerSupportsCancellation = true;
            this.backgroundWorkerAutoBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAutoBackup_DoWork);
            // 
            // aButtonRefresh
            // 
            this.aButtonRefresh.Image = global::_42LicenseManager.Properties.Resources.Refresh;
            this.aButtonRefresh.Location = new System.Drawing.Point(673, 56);
            this.aButtonRefresh.Name = "aButtonRefresh";
            this.aButtonRefresh.Size = new System.Drawing.Size(28, 24);
            this.aButtonRefresh.TabIndex = 2;
            this.aButtonRefresh.UseVisualStyleBackColor = true;
            this.aButtonRefresh.Click += new System.EventHandler(this.AButtonRefresh_Click);
            // 
            // aButtonSearch
            // 
            this.aButtonSearch.Enabled = false;
            this.aButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("aButtonSearch.Image")));
            this.aButtonSearch.Location = new System.Drawing.Point(783, 86);
            this.aButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.aButtonSearch.Name = "aButtonSearch";
            this.aButtonSearch.Size = new System.Drawing.Size(31, 25);
            this.aButtonSearch.TabIndex = 3;
            this.aButtonSearch.UseVisualStyleBackColor = true;
            this.aButtonSearch.Visible = false;
            this.aButtonSearch.Click += new System.EventHandler(this.aButtonSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_42LicenseManager.Properties.Resources._42logo_transparent___Copy300;
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 454);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Notes:";
            // 
            // aCheckBoxAutoRenew
            // 
            this.aCheckBoxAutoRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aCheckBoxAutoRenew.AutoSize = true;
            this.aCheckBoxAutoRenew.Location = new System.Drawing.Point(1087, 454);
            this.aCheckBoxAutoRenew.Name = "aCheckBoxAutoRenew";
            this.aCheckBoxAutoRenew.Size = new System.Drawing.Size(104, 21);
            this.aCheckBoxAutoRenew.TabIndex = 71;
            this.aCheckBoxAutoRenew.Text = "Auto-Renew";
            this.aCheckBoxAutoRenew.UseVisualStyleBackColor = true;
            this.aCheckBoxAutoRenew.Click += new System.EventHandler(this.aCheckBoxAutoRenew_Click);
            // 
            // aTextBoxNotes
            // 
            this.aTextBoxNotes.AcceptsReturn = true;
            this.aTextBoxNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aTextBoxNotes.Location = new System.Drawing.Point(14, 475);
            this.aTextBoxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxNotes.Multiline = true;
            this.aTextBoxNotes.Name = "aTextBoxNotes";
            this.aTextBoxNotes.ReadOnly = true;
            this.aTextBoxNotes.Size = new System.Drawing.Size(1177, 115);
            this.aTextBoxNotes.TabIndex = 17;
            this.aTextBoxNotes.TabStop = false;
            // 
            // licenseBindingSource
            // 
            this.licenseBindingSource.DataSource = typeof(_42LicenseManager.License);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 75;
            // 
            // ReviewStatus
            // 
            this.ReviewStatus.DataPropertyName = "ReviewStatus";
            this.ReviewStatus.HeaderText = "Review Status";
            this.ReviewStatus.Name = "ReviewStatus";
            this.ReviewStatus.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn.Width = 230;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 190;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 190;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "Expiration Date";
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            this.expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expirationDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // renewalStatusDataGridViewTextBoxColumn
            // 
            this.renewalStatusDataGridViewTextBoxColumn.DataPropertyName = "RenewalStatus";
            this.renewalStatusDataGridViewTextBoxColumn.HeaderText = "Renewal Status";
            this.renewalStatusDataGridViewTextBoxColumn.Name = "renewalStatusDataGridViewTextBoxColumn";
            this.renewalStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.renewalStatusDataGridViewTextBoxColumn.Width = 115;
            // 
            // pCCountDataGridViewTextBoxColumn
            // 
            this.pCCountDataGridViewTextBoxColumn.DataPropertyName = "PCCount";
            this.pCCountDataGridViewTextBoxColumn.HeaderText = "PC Count";
            this.pCCountDataGridViewTextBoxColumn.Name = "pCCountDataGridViewTextBoxColumn";
            this.pCCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCCountDataGridViewTextBoxColumn.Width = 75;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Width = 60;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Visible = false;
            // 
            // ChkBxAutoRenew
            // 
            this.ChkBxAutoRenew.DataPropertyName = "ChkBxAutoRenew";
            this.ChkBxAutoRenew.HeaderText = "ChkBxAutoRenew";
            this.ChkBxAutoRenew.Name = "ChkBxAutoRenew";
            this.ChkBxAutoRenew.ReadOnly = true;
            this.ChkBxAutoRenew.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1307, 616);
            this.Controls.Add(this.aTextBoxNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aCheckBoxAutoRenew);
            this.Controls.Add(this.aStatusStripDashboard);
            this.Controls.Add(this.aButtonRefresh);
            this.Controls.Add(this.aLabelView);
            this.Controls.Add(this.aButtonViewAllLogs);
            this.Controls.Add(this.aButtonCheckForExpires);
            this.Controls.Add(this.aLabelLicenseFoundInt);
            this.Controls.Add(this.aLabelLicenseFoundLabel);
            this.Controls.Add(this.aButtonDelete);
            this.Controls.Add(this.aButtonAddLicense);
            this.Controls.Add(this.aButtonTest);
            this.Controls.Add(this.aTextBoxSearch);
            this.Controls.Add(this.aComboboxSortBy);
            this.Controls.Add(this.aDataGridViewLicenses);
            this.Controls.Add(this.aButtonEdit);
            this.Controls.Add(this.aLabelSearch);
            this.Controls.Add(this.aButtonSearch);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1075, 450);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewLicenses)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label aLabelSearch;
        private System.Windows.Forms.Button aButtonEdit;
        private System.Windows.Forms.DataGridView aDataGridViewLicenses;
        private System.Windows.Forms.ComboBox aComboboxSortBy;
        private System.Windows.Forms.TextBox aTextBoxSearch;
        private System.Windows.Forms.Button aButtonTest;
        private System.Windows.Forms.Button aButtonAddLicense;
        private System.Windows.Forms.Button aButtonDelete;
        private System.Windows.Forms.Label aLabelLicenseFoundLabel;
        private System.Windows.Forms.Label aLabelLicenseFoundInt;
        private System.Windows.Forms.Button aButtonCheckForExpires;
        private System.Windows.Forms.ToolTip aToolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button aButtonViewAllLogs;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label aLabelView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource licenseBindingSource;
        private System.Windows.Forms.Button aButtonRefresh;
        private System.Windows.Forms.Button aButtonSearch;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupNowToolStripMenuItem;
        public System.Windows.Forms.StatusStrip aStatusStripDashboard;
        private System.Windows.Forms.ToolStripMenuItem selectDatabaseToolStripMenuItem;
        public System.ComponentModel.BackgroundWorker backgroundWorkerBackup;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAutoBackup;
        private System.Windows.Forms.ToolStripMenuItem importLicensesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox aCheckBoxAutoRenew;
        private System.Windows.Forms.TextBox aTextBoxNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renewalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChkBxAutoRenew;
    }
}

