namespace _42LicenseManager
{
    partial class ManagePCsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePCsForm));
            this.aDataGridViewMachines = new System.Windows.Forms.DataGridView();
            this.InstallDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aButtonClose = new System.Windows.Forms.Button();
            this.aButtonAdd = new System.Windows.Forms.Button();
            this.aButtonEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aButtonDelete = new System.Windows.Forms.Button();
            this.aButtonMove = new System.Windows.Forms.Button();
            this.aButtonImport = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licensedMachinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensedMachinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aDataGridViewMachines
            // 
            this.aDataGridViewMachines.AllowUserToAddRows = false;
            this.aDataGridViewMachines.AllowUserToDeleteRows = false;
            this.aDataGridViewMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridViewMachines.AutoGenerateColumns = false;
            this.aDataGridViewMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridViewMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.InstallDate,
            this.machineNameDataGridViewTextBoxColumn,
            this.machineNotesDataGridViewTextBoxColumn,
            this.licenseIdDataGridViewTextBoxColumn});
            this.aDataGridViewMachines.DataSource = this.licensedMachinesBindingSource;
            this.aDataGridViewMachines.Location = new System.Drawing.Point(35, 43);
            this.aDataGridViewMachines.Name = "aDataGridViewMachines";
            this.aDataGridViewMachines.ReadOnly = true;
            this.aDataGridViewMachines.Size = new System.Drawing.Size(643, 359);
            this.aDataGridViewMachines.TabIndex = 5;
            this.aDataGridViewMachines.TabStop = false;
            this.aDataGridViewMachines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDataGridViewMachines_CellDoubleClick);
            // 
            // InstallDate
            // 
            this.InstallDate.DataPropertyName = "InstallDate";
            this.InstallDate.HeaderText = "Install Date";
            this.InstallDate.Name = "InstallDate";
            this.InstallDate.ReadOnly = true;
            // 
            // aButtonClose
            // 
            this.aButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonClose.Location = new System.Drawing.Point(697, 379);
            this.aButtonClose.Name = "aButtonClose";
            this.aButtonClose.Size = new System.Drawing.Size(103, 23);
            this.aButtonClose.TabIndex = 5;
            this.aButtonClose.Text = "Close";
            this.aButtonClose.UseVisualStyleBackColor = true;
            this.aButtonClose.Click += new System.EventHandler(this.aButtonClose_Click);
            // 
            // aButtonAdd
            // 
            this.aButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonAdd.Location = new System.Drawing.Point(697, 44);
            this.aButtonAdd.Name = "aButtonAdd";
            this.aButtonAdd.Size = new System.Drawing.Size(101, 23);
            this.aButtonAdd.TabIndex = 1;
            this.aButtonAdd.Text = "Add Machine";
            this.aButtonAdd.UseVisualStyleBackColor = true;
            this.aButtonAdd.Click += new System.EventHandler(this.aButtonAdd_Click);
            // 
            // aButtonEdit
            // 
            this.aButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonEdit.Location = new System.Drawing.Point(697, 102);
            this.aButtonEdit.Name = "aButtonEdit";
            this.aButtonEdit.Size = new System.Drawing.Size(101, 23);
            this.aButtonEdit.TabIndex = 2;
            this.aButtonEdit.Text = "Edit Machine";
            this.aButtonEdit.UseVisualStyleBackColor = true;
            this.aButtonEdit.Click += new System.EventHandler(this.aButtonEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Machines Assigned to this License";
            // 
            // aButtonDelete
            // 
            this.aButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonDelete.Location = new System.Drawing.Point(697, 160);
            this.aButtonDelete.Name = "aButtonDelete";
            this.aButtonDelete.Size = new System.Drawing.Size(101, 23);
            this.aButtonDelete.TabIndex = 4;
            this.aButtonDelete.Text = "Delete Machine";
            this.aButtonDelete.UseVisualStyleBackColor = true;
            this.aButtonDelete.Click += new System.EventHandler(this.aButtonDelete_Click);
            // 
            // aButtonMove
            // 
            this.aButtonMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonMove.Location = new System.Drawing.Point(697, 131);
            this.aButtonMove.Name = "aButtonMove";
            this.aButtonMove.Size = new System.Drawing.Size(101, 23);
            this.aButtonMove.TabIndex = 3;
            this.aButtonMove.Text = "Move";
            this.aButtonMove.UseVisualStyleBackColor = true;
            this.aButtonMove.Click += new System.EventHandler(this.AButtonMove_Click);
            // 
            // aButtonImport
            // 
            this.aButtonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonImport.Location = new System.Drawing.Point(697, 73);
            this.aButtonImport.Name = "aButtonImport";
            this.aButtonImport.Size = new System.Drawing.Size(101, 23);
            this.aButtonImport.TabIndex = 6;
            this.aButtonImport.Text = "Import Machines";
            this.aButtonImport.UseVisualStyleBackColor = true;
            this.aButtonImport.Click += new System.EventHandler(this.aButtonImport_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "MachineName";
            this.machineNameDataGridViewTextBoxColumn.HeaderText = "MachineName";
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            this.machineNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.machineNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // machineNotesDataGridViewTextBoxColumn
            // 
            this.machineNotesDataGridViewTextBoxColumn.DataPropertyName = "MachineNotes";
            this.machineNotesDataGridViewTextBoxColumn.HeaderText = "MachineNotes";
            this.machineNotesDataGridViewTextBoxColumn.Name = "machineNotesDataGridViewTextBoxColumn";
            this.machineNotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.machineNotesDataGridViewTextBoxColumn.Width = 350;
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
            // ManagePCsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 428);
            this.Controls.Add(this.aButtonImport);
            this.Controls.Add(this.aButtonMove);
            this.Controls.Add(this.aButtonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aButtonEdit);
            this.Controls.Add(this.aButtonAdd);
            this.Controls.Add(this.aButtonClose);
            this.Controls.Add(this.aDataGridViewMachines);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagePCsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Machines Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagePCsForm_FormClosing);
            this.Load += new System.EventHandler(this.ManagePCsForm_Load);
            this.Shown += new System.EventHandler(this.ManagePCsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licensedMachinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aDataGridViewMachines;
        private System.Windows.Forms.Button aButtonClose;
        private System.Windows.Forms.Button aButtonAdd;
        private System.Windows.Forms.Button aButtonEdit;
        private System.Windows.Forms.BindingSource licensedMachinesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aButtonDelete;
        private System.Windows.Forms.Button aButtonMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button aButtonImport;
    }
}