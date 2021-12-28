
namespace _42LicenseManager.Forms
{
    partial class SelectDatabaseForm
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
            this.aDGVDatabases = new System.Windows.Forms.DataGridView();
            this.dbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aButtonSelect = new System.Windows.Forms.Button();
            this.aButtonAdd = new System.Windows.Forms.Button();
            this.aButtonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aDGVDatabases)).BeginInit();
            this.SuspendLayout();
            // 
            // aDGVDatabases
            // 
            this.aDGVDatabases.AllowUserToAddRows = false;
            this.aDGVDatabases.AllowUserToDeleteRows = false;
            this.aDGVDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDGVDatabases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dbName,
            this.dbDir});
            this.aDGVDatabases.Location = new System.Drawing.Point(12, 30);
            this.aDGVDatabases.Name = "aDGVDatabases";
            this.aDGVDatabases.ReadOnly = true;
            this.aDGVDatabases.Size = new System.Drawing.Size(844, 152);
            this.aDGVDatabases.TabIndex = 0;
            this.aDGVDatabases.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aDGVDatabases_CellDoubleClick);
            this.aDGVDatabases.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.aDGVDatabases_CellFormatting);
            // 
            // dbName
            // 
            this.dbName.HeaderText = "Name";
            this.dbName.Name = "dbName";
            this.dbName.ReadOnly = true;
            this.dbName.Width = 200;
            // 
            // dbDir
            // 
            this.dbDir.HeaderText = "Directory";
            this.dbDir.Name = "dbDir";
            this.dbDir.ReadOnly = true;
            this.dbDir.Width = 600;
            // 
            // aButtonSelect
            // 
            this.aButtonSelect.Location = new System.Drawing.Point(752, 192);
            this.aButtonSelect.Name = "aButtonSelect";
            this.aButtonSelect.Size = new System.Drawing.Size(104, 40);
            this.aButtonSelect.TabIndex = 1;
            this.aButtonSelect.Text = "Select";
            this.aButtonSelect.UseVisualStyleBackColor = true;
            this.aButtonSelect.Click += new System.EventHandler(this.aButtonSelect_Click);
            // 
            // aButtonAdd
            // 
            this.aButtonAdd.Location = new System.Drawing.Point(12, 192);
            this.aButtonAdd.Name = "aButtonAdd";
            this.aButtonAdd.Size = new System.Drawing.Size(104, 40);
            this.aButtonAdd.TabIndex = 2;
            this.aButtonAdd.Text = "Add";
            this.aButtonAdd.UseVisualStyleBackColor = true;
            this.aButtonAdd.Click += new System.EventHandler(this.aButtonAdd_Click);
            // 
            // aButtonRemove
            // 
            this.aButtonRemove.Location = new System.Drawing.Point(122, 192);
            this.aButtonRemove.Name = "aButtonRemove";
            this.aButtonRemove.Size = new System.Drawing.Size(104, 40);
            this.aButtonRemove.TabIndex = 3;
            this.aButtonRemove.Text = "Remove from list";
            this.aButtonRemove.UseVisualStyleBackColor = true;
            this.aButtonRemove.Click += new System.EventHandler(this.aButtonRemove_Click);
            // 
            // SelectDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 239);
            this.Controls.Add(this.aButtonRemove);
            this.Controls.Add(this.aButtonAdd);
            this.Controls.Add(this.aButtonSelect);
            this.Controls.Add(this.aDGVDatabases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectDatabaseForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Database";
            this.Load += new System.EventHandler(this.SelectDatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aDGVDatabases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView aDGVDatabases;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbDir;
        private System.Windows.Forms.Button aButtonSelect;
        private System.Windows.Forms.Button aButtonAdd;
        private System.Windows.Forms.Button aButtonRemove;
    }
}