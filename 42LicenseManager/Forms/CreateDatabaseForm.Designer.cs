namespace _42LicenseManager
{
    partial class CreateDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDatabaseForm));
            this.aButtonCreateNewDatabase = new System.Windows.Forms.Button();
            this.aButtonBrowse = new System.Windows.Forms.Button();
            this.aLabelTimeToRenew = new System.Windows.Forms.Label();
            this.aTextBoxTimeToRenew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aTextBoxNewDBDir = new System.Windows.Forms.TextBox();
            this.aLabelDatabaseName = new System.Windows.Forms.Label();
            this.aTextBoxDatabaseName = new System.Windows.Forms.TextBox();
            this.aLabeldotmdf = new System.Windows.Forms.Label();
            this.aLabelHelp = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.aCheckBoxAllowDupeMachines = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // aButtonCreateNewDatabase
            // 
            this.aButtonCreateNewDatabase.Location = new System.Drawing.Point(476, 80);
            this.aButtonCreateNewDatabase.Name = "aButtonCreateNewDatabase";
            this.aButtonCreateNewDatabase.Size = new System.Drawing.Size(129, 23);
            this.aButtonCreateNewDatabase.TabIndex = 5;
            this.aButtonCreateNewDatabase.Text = "Create New Database";
            this.aButtonCreateNewDatabase.UseVisualStyleBackColor = true;
            this.aButtonCreateNewDatabase.Click += new System.EventHandler(this.AButtonCreateNewDatabase_Click);
            // 
            // aButtonBrowse
            // 
            this.aButtonBrowse.Location = new System.Drawing.Point(530, 12);
            this.aButtonBrowse.Name = "aButtonBrowse";
            this.aButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.aButtonBrowse.TabIndex = 2;
            this.aButtonBrowse.Text = "Browse";
            this.aButtonBrowse.UseVisualStyleBackColor = true;
            this.aButtonBrowse.Click += new System.EventHandler(this.AButtonBrowse_Click);
            // 
            // aLabelTimeToRenew
            // 
            this.aLabelTimeToRenew.AutoSize = true;
            this.aLabelTimeToRenew.Location = new System.Drawing.Point(27, 67);
            this.aLabelTimeToRenew.Name = "aLabelTimeToRenew";
            this.aLabelTimeToRenew.Size = new System.Drawing.Size(122, 13);
            this.aLabelTimeToRenew.TabIndex = 11;
            this.aLabelTimeToRenew.Text = "Days until time to renew:";
            // 
            // aTextBoxTimeToRenew
            // 
            this.aTextBoxTimeToRenew.Location = new System.Drawing.Point(155, 64);
            this.aTextBoxTimeToRenew.Name = "aTextBoxTimeToRenew";
            this.aTextBoxTimeToRenew.Size = new System.Drawing.Size(93, 20);
            this.aTextBoxTimeToRenew.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Database Directory:";
            // 
            // aTextBoxNewDBDir
            // 
            this.aTextBoxNewDBDir.Location = new System.Drawing.Point(155, 12);
            this.aTextBoxNewDBDir.Name = "aTextBoxNewDBDir";
            this.aTextBoxNewDBDir.Size = new System.Drawing.Size(369, 20);
            this.aTextBoxNewDBDir.TabIndex = 1;
            this.aTextBoxNewDBDir.Leave += new System.EventHandler(this.ATextBoxNewDBDir_Leave);
            // 
            // aLabelDatabaseName
            // 
            this.aLabelDatabaseName.AutoSize = true;
            this.aLabelDatabaseName.Location = new System.Drawing.Point(59, 41);
            this.aLabelDatabaseName.Name = "aLabelDatabaseName";
            this.aLabelDatabaseName.Size = new System.Drawing.Size(90, 13);
            this.aLabelDatabaseName.TabIndex = 15;
            this.aLabelDatabaseName.Text = "Database Name: ";
            // 
            // aTextBoxDatabaseName
            // 
            this.aTextBoxDatabaseName.Location = new System.Drawing.Point(155, 38);
            this.aTextBoxDatabaseName.Name = "aTextBoxDatabaseName";
            this.aTextBoxDatabaseName.Size = new System.Drawing.Size(166, 20);
            this.aTextBoxDatabaseName.TabIndex = 3;
            this.aTextBoxDatabaseName.Leave += new System.EventHandler(this.ATextBoxDatabaseName_Leave);
            // 
            // aLabeldotmdf
            // 
            this.aLabeldotmdf.AutoSize = true;
            this.aLabeldotmdf.Location = new System.Drawing.Point(321, 42);
            this.aLabeldotmdf.Name = "aLabeldotmdf";
            this.aLabeldotmdf.Size = new System.Drawing.Size(27, 13);
            this.aLabeldotmdf.TabIndex = 16;
            this.aLabeldotmdf.Text = ".mdf";
            // 
            // aLabelHelp
            // 
            this.aLabelHelp.AutoSize = true;
            this.aLabelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelHelp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.aLabelHelp.Location = new System.Drawing.Point(248, 63);
            this.aLabelHelp.Name = "aLabelHelp";
            this.aLabelHelp.Size = new System.Drawing.Size(19, 13);
            this.aLabelHelp.TabIndex = 17;
            this.aLabelHelp.Text = "(?)";
            this.toolTip1.SetToolTip(this.aLabelHelp, "How many days prior to a license expiring to \r\nset it as \'Open\' for review.");
            // 
            // aCheckBoxAllowDupeMachines
            // 
            this.aCheckBoxAllowDupeMachines.AutoSize = true;
            this.aCheckBoxAllowDupeMachines.Checked = true;
            this.aCheckBoxAllowDupeMachines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aCheckBoxAllowDupeMachines.Location = new System.Drawing.Point(155, 91);
            this.aCheckBoxAllowDupeMachines.Name = "aCheckBoxAllowDupeMachines";
            this.aCheckBoxAllowDupeMachines.Size = new System.Drawing.Size(174, 17);
            this.aCheckBoxAllowDupeMachines.TabIndex = 18;
            this.aCheckBoxAllowDupeMachines.Text = "Allow duplicate machine names";
            this.toolTip1.SetToolTip(this.aCheckBoxAllowDupeMachines, "Allows multiple machines, regardless of who owns them, to have the same name. \r\n\r" +
        "\nWarning: Once this is enabled it cannot be disabled!");
            this.aCheckBoxAllowDupeMachines.UseVisualStyleBackColor = true;
            // 
            // CreateDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(623, 115);
            this.Controls.Add(this.aCheckBoxAllowDupeMachines);
            this.Controls.Add(this.aLabelHelp);
            this.Controls.Add(this.aLabeldotmdf);
            this.Controls.Add(this.aLabelDatabaseName);
            this.Controls.Add(this.aTextBoxDatabaseName);
            this.Controls.Add(this.aButtonCreateNewDatabase);
            this.Controls.Add(this.aButtonBrowse);
            this.Controls.Add(this.aLabelTimeToRenew);
            this.Controls.Add(this.aTextBoxTimeToRenew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aTextBoxNewDBDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aButtonCreateNewDatabase;
        private System.Windows.Forms.Button aButtonBrowse;
        private System.Windows.Forms.Label aLabelTimeToRenew;
        private System.Windows.Forms.TextBox aTextBoxTimeToRenew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aTextBoxNewDBDir;
        private System.Windows.Forms.Label aLabelDatabaseName;
        private System.Windows.Forms.TextBox aTextBoxDatabaseName;
        private System.Windows.Forms.Label aLabeldotmdf;
        private System.Windows.Forms.Label aLabelHelp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox aCheckBoxAllowDupeMachines;
    }
}