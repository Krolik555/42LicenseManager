namespace _42LicenseManager
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.aTextBoxDir = new System.Windows.Forms.TextBox();
            this.aButtonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aLabelTimeToRenew = new System.Windows.Forms.Label();
            this.aTextBoxTimeToRenew = new System.Windows.Forms.TextBox();
            this.aButtonBrowse = new System.Windows.Forms.Button();
            this.aButtonCreateNewDatabase = new System.Windows.Forms.Button();
            this.aLabelHelp = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.aCheckBoxAllowDupeMachines = new System.Windows.Forms.CheckBox();
            this.aCheckBoxAllowDupeClients = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.aButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aTextBoxDir
            // 
            this.aTextBoxDir.Location = new System.Drawing.Point(140, 50);
            this.aTextBoxDir.Name = "aTextBoxDir";
            this.aTextBoxDir.Size = new System.Drawing.Size(406, 20);
            this.aTextBoxDir.TabIndex = 0;
            this.aTextBoxDir.Leave += new System.EventHandler(this.ATextBoxDir_Leave);
            // 
            // aButtonSave
            // 
            this.aButtonSave.Location = new System.Drawing.Point(363, 100);
            this.aButtonSave.Name = "aButtonSave";
            this.aButtonSave.Size = new System.Drawing.Size(129, 23);
            this.aButtonSave.TabIndex = 1;
            this.aButtonSave.Text = "Save";
            this.aButtonSave.UseVisualStyleBackColor = true;
            this.aButtonSave.Click += new System.EventHandler(this.aButtonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database directory:";
            // 
            // aLabelTimeToRenew
            // 
            this.aLabelTimeToRenew.AutoSize = true;
            this.aLabelTimeToRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelTimeToRenew.Location = new System.Drawing.Point(5, 77);
            this.aLabelTimeToRenew.Name = "aLabelTimeToRenew";
            this.aLabelTimeToRenew.Size = new System.Drawing.Size(122, 13);
            this.aLabelTimeToRenew.TabIndex = 4;
            this.aLabelTimeToRenew.Text = "Days until time to renew:";
            // 
            // aTextBoxTimeToRenew
            // 
            this.aTextBoxTimeToRenew.Location = new System.Drawing.Point(140, 74);
            this.aTextBoxTimeToRenew.Name = "aTextBoxTimeToRenew";
            this.aTextBoxTimeToRenew.Size = new System.Drawing.Size(93, 20);
            this.aTextBoxTimeToRenew.TabIndex = 3;
            // 
            // aButtonBrowse
            // 
            this.aButtonBrowse.Location = new System.Drawing.Point(552, 48);
            this.aButtonBrowse.Name = "aButtonBrowse";
            this.aButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.aButtonBrowse.TabIndex = 5;
            this.aButtonBrowse.Text = "Browse";
            this.aButtonBrowse.UseVisualStyleBackColor = true;
            this.aButtonBrowse.Click += new System.EventHandler(this.AButtonBrowse_Click);
            // 
            // aButtonCreateNewDatabase
            // 
            this.aButtonCreateNewDatabase.Location = new System.Drawing.Point(228, 100);
            this.aButtonCreateNewDatabase.Name = "aButtonCreateNewDatabase";
            this.aButtonCreateNewDatabase.Size = new System.Drawing.Size(129, 23);
            this.aButtonCreateNewDatabase.TabIndex = 6;
            this.aButtonCreateNewDatabase.Text = "Create New Database";
            this.aButtonCreateNewDatabase.UseVisualStyleBackColor = true;
            this.aButtonCreateNewDatabase.Click += new System.EventHandler(this.AButtonCreateNewDatabase_Click);
            // 
            // aLabelHelp
            // 
            this.aLabelHelp.AutoSize = true;
            this.aLabelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelHelp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.aLabelHelp.Location = new System.Drawing.Point(123, 76);
            this.aLabelHelp.Name = "aLabelHelp";
            this.aLabelHelp.Size = new System.Drawing.Size(19, 13);
            this.aLabelHelp.TabIndex = 9;
            this.aLabelHelp.Text = "(?)";
            this.toolTip1.SetToolTip(this.aLabelHelp, "How many days prior to a license expiring to \r\nset it as \'Open\' for review.\r\n");
            // 
            // aCheckBoxAllowDupeMachines
            // 
            this.aCheckBoxAllowDupeMachines.AutoSize = true;
            this.aCheckBoxAllowDupeMachines.Location = new System.Drawing.Point(12, 116);
            this.aCheckBoxAllowDupeMachines.Name = "aCheckBoxAllowDupeMachines";
            this.aCheckBoxAllowDupeMachines.Size = new System.Drawing.Size(174, 17);
            this.aCheckBoxAllowDupeMachines.TabIndex = 12;
            this.aCheckBoxAllowDupeMachines.Text = "Allow duplicate machine names";
            this.toolTip1.SetToolTip(this.aCheckBoxAllowDupeMachines, "This allows multiple machines, regardless of owner, to have identical names.\r\n\r\nW" +
        "arning: Once this is enabled it cannot be disabled!");
            this.aCheckBoxAllowDupeMachines.UseVisualStyleBackColor = true;
            this.aCheckBoxAllowDupeMachines.CheckStateChanged += new System.EventHandler(this.aCheckBoxAllowDupeMachines_CheckStateChanged);
            // 
            // aCheckBoxAllowDupeClients
            // 
            this.aCheckBoxAllowDupeClients.AutoSize = true;
            this.aCheckBoxAllowDupeClients.Location = new System.Drawing.Point(12, 100);
            this.aCheckBoxAllowDupeClients.Name = "aCheckBoxAllowDupeClients";
            this.aCheckBoxAllowDupeClients.Size = new System.Drawing.Size(130, 17);
            this.aCheckBoxAllowDupeClients.TabIndex = 14;
            this.aCheckBoxAllowDupeClients.Text = "Allow duplicate clients";
            this.toolTip1.SetToolTip(this.aCheckBoxAllowDupeClients, resources.GetString("aCheckBoxAllowDupeClients.ToolTip"));
            this.aCheckBoxAllowDupeClients.UseVisualStyleBackColor = true;
            this.aCheckBoxAllowDupeClients.CheckStateChanged += new System.EventHandler(this.aCheckBoxAllowDupeClients_CheckStateChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(612, 32);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Add an existing database";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aButtonCancel
            // 
            this.aButtonCancel.Location = new System.Drawing.Point(498, 100);
            this.aButtonCancel.Name = "aButtonCancel";
            this.aButtonCancel.Size = new System.Drawing.Size(129, 23);
            this.aButtonCancel.TabIndex = 11;
            this.aButtonCancel.Text = "Cancel";
            this.aButtonCancel.UseVisualStyleBackColor = true;
            this.aButtonCancel.Click += new System.EventHandler(this.AButtonCancel_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 134);
            this.ControlBox = false;
            this.Controls.Add(this.aCheckBoxAllowDupeClients);
            this.Controls.Add(this.aCheckBoxAllowDupeMachines);
            this.Controls.Add(this.aButtonCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aButtonCreateNewDatabase);
            this.Controls.Add(this.aButtonBrowse);
            this.Controls.Add(this.aLabelTimeToRenew);
            this.Controls.Add(this.aTextBoxTimeToRenew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aButtonSave);
            this.Controls.Add(this.aTextBoxDir);
            this.Controls.Add(this.aLabelHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add existing database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aTextBoxDir;
        private System.Windows.Forms.Button aButtonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aLabelTimeToRenew;
        private System.Windows.Forms.TextBox aTextBoxTimeToRenew;
        private System.Windows.Forms.Button aButtonBrowse;
        private System.Windows.Forms.Button aButtonCreateNewDatabase;
        private System.Windows.Forms.Label aLabelHelp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button aButtonCancel;
        private System.Windows.Forms.CheckBox aCheckBoxAllowDupeMachines;
        private System.Windows.Forms.CheckBox aCheckBoxAllowDupeClients;
    }
}