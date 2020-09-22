namespace _42LicenseManager
{
    partial class MoveForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveForm));
            this.aTextBoxSearch = new System.Windows.Forms.TextBox();
            this.aLabelSearch = new System.Windows.Forms.Label();
            this.aDataGridViewLicenses = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renewalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.licenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aDataGridViewMachines = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensedMachinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLabelTitle = new System.Windows.Forms.Label();
            this.aButtonMoveHere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensedMachinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aTextBoxSearch
            // 
            this.aTextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aTextBoxSearch.Location = new System.Drawing.Point(724, 21);
            this.aTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxSearch.Name = "aTextBoxSearch";
            this.aTextBoxSearch.Size = new System.Drawing.Size(305, 20);
            this.aTextBoxSearch.TabIndex = 4;
            this.aTextBoxSearch.TextChanged += new System.EventHandler(this.ATextBoxSearch_TextChanged);
            this.aTextBoxSearch.Leave += new System.EventHandler(this.ATextBoxSearch_Leave);
            // 
            // aLabelSearch
            // 
            this.aLabelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aLabelSearch.AutoSize = true;
            this.aLabelSearch.Location = new System.Drawing.Point(659, 24);
            this.aLabelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aLabelSearch.Name = "aLabelSearch";
            this.aLabelSearch.Size = new System.Drawing.Size(44, 13);
            this.aLabelSearch.TabIndex = 5;
            this.aLabelSearch.Text = "Search:";
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
            this.Id,
            this.reviewStatusDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.renewalStatusDataGridViewTextBoxColumn,
            this.pCCountDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.aDataGridViewLicenses.DataSource = this.licenseBindingSource;
            this.aDataGridViewLicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.aDataGridViewLicenses.Location = new System.Drawing.Point(11, 48);
            this.aDataGridViewLicenses.MultiSelect = false;
            this.aDataGridViewLicenses.Name = "aDataGridViewLicenses";
            this.aDataGridViewLicenses.ReadOnly = true;
            this.aDataGridViewLicenses.Size = new System.Drawing.Size(1018, 155);
            this.aDataGridViewLicenses.TabIndex = 6;
            this.aDataGridViewLicenses.TabStop = false;
            this.aDataGridViewLicenses.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ADataGridViewLicenses_CellEnter);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
            // 
            // reviewStatusDataGridViewTextBoxColumn
            // 
            this.reviewStatusDataGridViewTextBoxColumn.DataPropertyName = "ReviewStatus";
            this.reviewStatusDataGridViewTextBoxColumn.HeaderText = "Review Status";
            this.reviewStatusDataGridViewTextBoxColumn.Name = "reviewStatusDataGridViewTextBoxColumn";
            this.reviewStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.reviewStatusDataGridViewTextBoxColumn.Width = 75;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
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
            // licenseBindingSource
            // 
            this.licenseBindingSource.DataSource = typeof(_42LicenseManager.License);
            // 
            // aDataGridViewMachines
            // 
            this.aDataGridViewMachines.AllowUserToAddRows = false;
            this.aDataGridViewMachines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aDataGridViewMachines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.aDataGridViewMachines.AutoGenerateColumns = false;
            this.aDataGridViewMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridViewMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.machineNameDataGridViewTextBoxColumn,
            this.machineNotesDataGridViewTextBoxColumn,
            this.licenseIdDataGridViewTextBoxColumn});
            this.aDataGridViewMachines.DataSource = this.licensedMachinesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.aDataGridViewMachines.DefaultCellStyle = dataGridViewCellStyle3;
            this.aDataGridViewMachines.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.aDataGridViewMachines.Enabled = false;
            this.aDataGridViewMachines.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aDataGridViewMachines.Location = new System.Drawing.Point(12, 241);
            this.aDataGridViewMachines.MultiSelect = false;
            this.aDataGridViewMachines.Name = "aDataGridViewMachines";
            this.aDataGridViewMachines.ReadOnly = true;
            this.aDataGridViewMachines.ShowEditingIcon = false;
            this.aDataGridViewMachines.Size = new System.Drawing.Size(448, 150);
            this.aDataGridViewMachines.TabIndex = 7;
            this.aDataGridViewMachines.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "MachineName";
            this.machineNameDataGridViewTextBoxColumn.HeaderText = "Machine Name";
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            this.machineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineNotesDataGridViewTextBoxColumn
            // 
            this.machineNotesDataGridViewTextBoxColumn.DataPropertyName = "MachineNotes";
            this.machineNotesDataGridViewTextBoxColumn.HeaderText = "MachineNotes";
            this.machineNotesDataGridViewTextBoxColumn.Name = "machineNotesDataGridViewTextBoxColumn";
            this.machineNotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.machineNotesDataGridViewTextBoxColumn.Visible = false;
            // 
            // licenseIdDataGridViewTextBoxColumn
            // 
            this.licenseIdDataGridViewTextBoxColumn.DataPropertyName = "LicenseId";
            this.licenseIdDataGridViewTextBoxColumn.HeaderText = "LicenseId";
            this.licenseIdDataGridViewTextBoxColumn.Name = "licenseIdDataGridViewTextBoxColumn";
            this.licenseIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // licensedMachinesBindingSource
            // 
            this.licensedMachinesBindingSource.DataSource = typeof(_42LicenseManager.LicensedMachines);
            // 
            // aLabelTitle
            // 
            this.aLabelTitle.AutoSize = true;
            this.aLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelTitle.Location = new System.Drawing.Point(6, 10);
            this.aLabelTitle.Name = "aLabelTitle";
            this.aLabelTitle.Size = new System.Drawing.Size(370, 31);
            this.aLabelTitle.TabIndex = 8;
            this.aLabelTitle.Text = "Select the desired destination";
            // 
            // aButtonMoveHere
            // 
            this.aButtonMoveHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aButtonMoveHere.Location = new System.Drawing.Point(754, 209);
            this.aButtonMoveHere.Name = "aButtonMoveHere";
            this.aButtonMoveHere.Size = new System.Drawing.Size(275, 40);
            this.aButtonMoveHere.TabIndex = 9;
            this.aButtonMoveHere.Text = "Move to selected license";
            this.aButtonMoveHere.UseVisualStyleBackColor = true;
            this.aButtonMoveHere.Click += new System.EventHandler(this.AButtonMoveHere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Machines belonging to the license selected above:";
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aButtonMoveHere);
            this.Controls.Add(this.aLabelTitle);
            this.Controls.Add(this.aDataGridViewMachines);
            this.Controls.Add(this.aDataGridViewLicenses);
            this.Controls.Add(this.aTextBoxSearch);
            this.Controls.Add(this.aLabelSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Move Machines";
            this.Shown += new System.EventHandler(this.MoveForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensedMachinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aTextBoxSearch;
        private System.Windows.Forms.Label aLabelSearch;
        private System.Windows.Forms.DataGridView aDataGridViewLicenses;
        private System.Windows.Forms.BindingSource licenseBindingSource;
        private System.Windows.Forms.DataGridView aDataGridViewMachines;
        private System.Windows.Forms.BindingSource licensedMachinesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label aLabelTitle;
        private System.Windows.Forms.Button aButtonMoveHere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renewalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}