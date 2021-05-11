
namespace _42LicenseManager.Forms
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.label1 = new System.Windows.Forms.Label();
            this.aTextboxBackupTarget = new System.Windows.Forms.TextBox();
            this.aButtonBrowse = new System.Windows.Forms.Button();
            this.aCheckBoxAutoBackup = new System.Windows.Forms.CheckBox();
            this.aGroupBackup = new System.Windows.Forms.GroupBox();
            this.aComboboxBackupSchedule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aComboboxBackupExpiration = new System.Windows.Forms.ComboBox();
            this.aButtonSave = new System.Windows.Forms.Button();
            this.aButtonCancel = new System.Windows.Forms.Button();
            this.aGroupBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup Location:";
            // 
            // aTextboxBackupTarget
            // 
            this.aTextboxBackupTarget.Location = new System.Drawing.Point(128, 21);
            this.aTextboxBackupTarget.Name = "aTextboxBackupTarget";
            this.aTextboxBackupTarget.Size = new System.Drawing.Size(396, 20);
            this.aTextboxBackupTarget.TabIndex = 1;
            // 
            // aButtonBrowse
            // 
            this.aButtonBrowse.Location = new System.Drawing.Point(530, 21);
            this.aButtonBrowse.Name = "aButtonBrowse";
            this.aButtonBrowse.Size = new System.Drawing.Size(75, 20);
            this.aButtonBrowse.TabIndex = 3;
            this.aButtonBrowse.Text = "Browse";
            this.aButtonBrowse.UseVisualStyleBackColor = true;
            this.aButtonBrowse.Click += new System.EventHandler(this.aButtonBrowse_Click);
            // 
            // aCheckBoxAutoBackup
            // 
            this.aCheckBoxAutoBackup.AutoSize = true;
            this.aCheckBoxAutoBackup.Location = new System.Drawing.Point(35, 79);
            this.aCheckBoxAutoBackup.Name = "aCheckBoxAutoBackup";
            this.aCheckBoxAutoBackup.Size = new System.Drawing.Size(128, 17);
            this.aCheckBoxAutoBackup.TabIndex = 4;
            this.aCheckBoxAutoBackup.Text = "Automatically Backup";
            this.aCheckBoxAutoBackup.UseVisualStyleBackColor = true;
            this.aCheckBoxAutoBackup.CheckedChanged += new System.EventHandler(this.aCheckBoxAutoBackup_CheckedChanged);
            // 
            // aGroupBackup
            // 
            this.aGroupBackup.Controls.Add(this.label4);
            this.aGroupBackup.Controls.Add(this.label5);
            this.aGroupBackup.Controls.Add(this.aComboboxBackupExpiration);
            this.aGroupBackup.Controls.Add(this.label3);
            this.aGroupBackup.Controls.Add(this.label2);
            this.aGroupBackup.Controls.Add(this.aComboboxBackupSchedule);
            this.aGroupBackup.Enabled = false;
            this.aGroupBackup.Location = new System.Drawing.Point(49, 95);
            this.aGroupBackup.Name = "aGroupBackup";
            this.aGroupBackup.Size = new System.Drawing.Size(322, 90);
            this.aGroupBackup.TabIndex = 5;
            this.aGroupBackup.TabStop = false;
            // 
            // aComboboxBackupSchedule
            // 
            this.aComboboxBackupSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxBackupSchedule.FormattingEnabled = true;
            this.aComboboxBackupSchedule.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "24"});
            this.aComboboxBackupSchedule.Location = new System.Drawing.Point(134, 13);
            this.aComboboxBackupSchedule.Name = "aComboboxBackupSchedule";
            this.aComboboxBackupSchedule.Size = new System.Drawing.Size(101, 21);
            this.aComboboxBackupSchedule.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Backup every";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "months";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Keep backups for";
            // 
            // aComboboxBackupExpiration
            // 
            this.aComboboxBackupExpiration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxBackupExpiration.FormattingEnabled = true;
            this.aComboboxBackupExpiration.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.aComboboxBackupExpiration.Location = new System.Drawing.Point(134, 49);
            this.aComboboxBackupExpiration.Name = "aComboboxBackupExpiration";
            this.aComboboxBackupExpiration.Size = new System.Drawing.Size(101, 21);
            this.aComboboxBackupExpiration.TabIndex = 8;
            // 
            // aButtonSave
            // 
            this.aButtonSave.Location = new System.Drawing.Point(540, 162);
            this.aButtonSave.Name = "aButtonSave";
            this.aButtonSave.Size = new System.Drawing.Size(75, 23);
            this.aButtonSave.TabIndex = 6;
            this.aButtonSave.Text = "Save";
            this.aButtonSave.UseVisualStyleBackColor = true;
            this.aButtonSave.Click += new System.EventHandler(this.aButtonSave_Click);
            // 
            // aButtonCancel
            // 
            this.aButtonCancel.Location = new System.Drawing.Point(459, 162);
            this.aButtonCancel.Name = "aButtonCancel";
            this.aButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.aButtonCancel.TabIndex = 7;
            this.aButtonCancel.Text = "Cancel";
            this.aButtonCancel.UseVisualStyleBackColor = true;
            this.aButtonCancel.Click += new System.EventHandler(this.aButtonCancel_Click);
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 198);
            this.Controls.Add(this.aButtonCancel);
            this.Controls.Add(this.aButtonSave);
            this.Controls.Add(this.aGroupBackup);
            this.Controls.Add(this.aButtonBrowse);
            this.Controls.Add(this.aTextboxBackupTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aCheckBoxAutoBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "42LicenseManager>Configure Backup";
            this.aGroupBackup.ResumeLayout(false);
            this.aGroupBackup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aTextboxBackupTarget;
        private System.Windows.Forms.Button aButtonBrowse;
        private System.Windows.Forms.CheckBox aCheckBoxAutoBackup;
        private System.Windows.Forms.GroupBox aGroupBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox aComboboxBackupSchedule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox aComboboxBackupExpiration;
        private System.Windows.Forms.Button aButtonSave;
        private System.Windows.Forms.Button aButtonCancel;
    }
}