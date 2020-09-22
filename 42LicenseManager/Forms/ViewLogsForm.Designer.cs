namespace _42LicenseManager
{
    partial class ViewLogsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogsForm));
            this.aDataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aButtonDeleteLog = new System.Windows.Forms.Button();
            this.aButtonClose = new System.Windows.Forms.Button();
            this.aTextBoxSearch = new System.Windows.Forms.TextBox();
            this.aLabelSearch = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logClassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logClassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aDataGridViewLogs
            // 
            this.aDataGridViewLogs.AllowUserToAddRows = false;
            this.aDataGridViewLogs.AllowUserToDeleteRows = false;
            this.aDataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aDataGridViewLogs.AutoGenerateColumns = false;
            this.aDataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDataGridViewLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Date,
            this.licenseIdDataGridViewTextBoxColumn,
            this.logDataGridViewTextBoxColumn});
            this.aDataGridViewLogs.DataSource = this.logClassBindingSource1;
            this.aDataGridViewLogs.Location = new System.Drawing.Point(12, 40);
            this.aDataGridViewLogs.Name = "aDataGridViewLogs";
            this.aDataGridViewLogs.ReadOnly = true;
            this.aDataGridViewLogs.Size = new System.Drawing.Size(772, 219);
            this.aDataGridViewLogs.TabIndex = 0;
            this.aDataGridViewLogs.TabStop = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 110;
            // 
            // aButtonDeleteLog
            // 
            this.aButtonDeleteLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonDeleteLog.Location = new System.Drawing.Point(612, 265);
            this.aButtonDeleteLog.Name = "aButtonDeleteLog";
            this.aButtonDeleteLog.Size = new System.Drawing.Size(75, 23);
            this.aButtonDeleteLog.TabIndex = 1;
            this.aButtonDeleteLog.Text = "Delete Log";
            this.aButtonDeleteLog.UseVisualStyleBackColor = true;
            this.aButtonDeleteLog.Click += new System.EventHandler(this.aButtonDeleteLog_Click);
            // 
            // aButtonClose
            // 
            this.aButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aButtonClose.Location = new System.Drawing.Point(693, 265);
            this.aButtonClose.Name = "aButtonClose";
            this.aButtonClose.Size = new System.Drawing.Size(75, 23);
            this.aButtonClose.TabIndex = 2;
            this.aButtonClose.Text = "Close";
            this.aButtonClose.UseVisualStyleBackColor = true;
            this.aButtonClose.Click += new System.EventHandler(this.aButtonClose_Click);
            // 
            // aTextBoxSearch
            // 
            this.aTextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aTextBoxSearch.Location = new System.Drawing.Point(478, 13);
            this.aTextBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.aTextBoxSearch.Name = "aTextBoxSearch";
            this.aTextBoxSearch.Size = new System.Drawing.Size(305, 20);
            this.aTextBoxSearch.TabIndex = 4;
            this.aTextBoxSearch.TextChanged += new System.EventHandler(this.ATextBoxSearch_TextChanged);
            // 
            // aLabelSearch
            // 
            this.aLabelSearch.AutoSize = true;
            this.aLabelSearch.Location = new System.Drawing.Point(404, 16);
            this.aLabelSearch.Name = "aLabelSearch";
            this.aLabelSearch.Size = new System.Drawing.Size(70, 13);
            this.aLabelSearch.TabIndex = 5;
            this.aLabelSearch.Text = "Search Logs:";
            this.toolTip1.SetToolTip(this.aLabelSearch, "Note: This does not search the \"Date\" column.");
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // licenseIdDataGridViewTextBoxColumn
            // 
            this.licenseIdDataGridViewTextBoxColumn.DataPropertyName = "LicenseId";
            this.licenseIdDataGridViewTextBoxColumn.HeaderText = "LicenseId";
            this.licenseIdDataGridViewTextBoxColumn.Name = "licenseIdDataGridViewTextBoxColumn";
            this.licenseIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // logDataGridViewTextBoxColumn
            // 
            this.logDataGridViewTextBoxColumn.DataPropertyName = "Log";
            this.logDataGridViewTextBoxColumn.HeaderText = "Log";
            this.logDataGridViewTextBoxColumn.Name = "logDataGridViewTextBoxColumn";
            this.logDataGridViewTextBoxColumn.ReadOnly = true;
            this.logDataGridViewTextBoxColumn.Width = 600;
            // 
            // logClassBindingSource1
            // 
            this.logClassBindingSource1.DataSource = typeof(_42LicenseManager.LogClass);
            // 
            // logClassBindingSource
            // 
            this.logClassBindingSource.DataSource = typeof(_42LicenseManager.LogClass);
            // 
            // ViewLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 302);
            this.Controls.Add(this.aLabelSearch);
            this.Controls.Add(this.aTextBoxSearch);
            this.Controls.Add(this.aButtonClose);
            this.Controls.Add(this.aButtonDeleteLog);
            this.Controls.Add(this.aDataGridViewLogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewLogsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log History";
            this.Shown += new System.EventHandler(this.ViewLogsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.aDataGridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logClassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aDataGridViewLogs;
        private System.Windows.Forms.BindingSource logClassBindingSource1;
        private System.Windows.Forms.BindingSource logClassBindingSource;
        private System.Windows.Forms.Button aButtonDeleteLog;
        private System.Windows.Forms.Button aButtonClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox aTextBoxSearch;
        private System.Windows.Forms.Label aLabelSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}