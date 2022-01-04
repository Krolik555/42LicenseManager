namespace _42LicenseManager
{
    partial class EditLicensedMachineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditLicensedMachineForm));
            this.aLabelEdit = new System.Windows.Forms.Label();
            this.aLabelPcNotes = new System.Windows.Forms.Label();
            this.aTextBoxNotes = new System.Windows.Forms.TextBox();
            this.aLabelDateInstalled = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aTextBoxMachineName = new System.Windows.Forms.TextBox();
            this.aButtonSave = new System.Windows.Forms.Button();
            this.aDateTimePickerInstalled = new System.Windows.Forms.DateTimePicker();
            this.aCheckBoxUseDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // aLabelEdit
            // 
            this.aLabelEdit.AutoSize = true;
            this.aLabelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelEdit.Location = new System.Drawing.Point(183, 19);
            this.aLabelEdit.Name = "aLabelEdit";
            this.aLabelEdit.Size = new System.Drawing.Size(120, 24);
            this.aLabelEdit.TabIndex = 80;
            this.aLabelEdit.Text = "Edit Machine";
            // 
            // aLabelPcNotes
            // 
            this.aLabelPcNotes.AutoSize = true;
            this.aLabelPcNotes.Location = new System.Drawing.Point(54, 106);
            this.aLabelPcNotes.Name = "aLabelPcNotes";
            this.aLabelPcNotes.Size = new System.Drawing.Size(38, 13);
            this.aLabelPcNotes.TabIndex = 79;
            this.aLabelPcNotes.Text = "Notes:";
            // 
            // aTextBoxNotes
            // 
            this.aTextBoxNotes.AcceptsReturn = true;
            this.aTextBoxNotes.Location = new System.Drawing.Point(98, 103);
            this.aTextBoxNotes.Multiline = true;
            this.aTextBoxNotes.Name = "aTextBoxNotes";
            this.aTextBoxNotes.Size = new System.Drawing.Size(361, 170);
            this.aTextBoxNotes.TabIndex = 3;
            // 
            // aLabelDateInstalled
            // 
            this.aLabelDateInstalled.AutoSize = true;
            this.aLabelDateInstalled.Location = new System.Drawing.Point(17, 80);
            this.aLabelDateInstalled.Name = "aLabelDateInstalled";
            this.aLabelDateInstalled.Size = new System.Drawing.Size(75, 13);
            this.aLabelDateInstalled.TabIndex = 78;
            this.aLabelDateInstalled.Text = "Date Installed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Machines Name:";
            // 
            // aTextBoxMachineName
            // 
            this.aTextBoxMachineName.Location = new System.Drawing.Point(98, 51);
            this.aTextBoxMachineName.MaxLength = 30;
            this.aTextBoxMachineName.Name = "aTextBoxMachineName";
            this.aTextBoxMachineName.Size = new System.Drawing.Size(361, 20);
            this.aTextBoxMachineName.TabIndex = 1;
            // 
            // aButtonSave
            // 
            this.aButtonSave.Location = new System.Drawing.Point(384, 279);
            this.aButtonSave.Name = "aButtonSave";
            this.aButtonSave.Size = new System.Drawing.Size(75, 23);
            this.aButtonSave.TabIndex = 4;
            this.aButtonSave.Text = "Save";
            this.aButtonSave.UseVisualStyleBackColor = true;
            this.aButtonSave.Click += new System.EventHandler(this.aButtonSave_Click);
            // 
            // aDateTimePickerInstalled
            // 
            this.aDateTimePickerInstalled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePickerInstalled.Location = new System.Drawing.Point(98, 77);
            this.aDateTimePickerInstalled.Name = "aDateTimePickerInstalled";
            this.aDateTimePickerInstalled.Size = new System.Drawing.Size(141, 20);
            this.aDateTimePickerInstalled.TabIndex = 2;
            // 
            // aCheckBoxUseDate
            // 
            this.aCheckBoxUseDate.AutoSize = true;
            this.aCheckBoxUseDate.Checked = true;
            this.aCheckBoxUseDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aCheckBoxUseDate.Location = new System.Drawing.Point(246, 80);
            this.aCheckBoxUseDate.Name = "aCheckBoxUseDate";
            this.aCheckBoxUseDate.Size = new System.Drawing.Size(71, 17);
            this.aCheckBoxUseDate.TabIndex = 81;
            this.aCheckBoxUseDate.Text = "Use Date";
            this.aCheckBoxUseDate.UseVisualStyleBackColor = true;
            this.aCheckBoxUseDate.CheckedChanged += new System.EventHandler(this.ACheckBoxUseDate_CheckedChanged);
            // 
            // EditLicensedMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 317);
            this.Controls.Add(this.aCheckBoxUseDate);
            this.Controls.Add(this.aDateTimePickerInstalled);
            this.Controls.Add(this.aLabelEdit);
            this.Controls.Add(this.aLabelPcNotes);
            this.Controls.Add(this.aTextBoxNotes);
            this.Controls.Add(this.aLabelDateInstalled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aTextBoxMachineName);
            this.Controls.Add(this.aButtonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditLicensedMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Machine Info";
            this.Shown += new System.EventHandler(this.EditLicensedMachineForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabelEdit;
        private System.Windows.Forms.Label aLabelPcNotes;
        private System.Windows.Forms.TextBox aTextBoxNotes;
        private System.Windows.Forms.Label aLabelDateInstalled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aTextBoxMachineName;
        private System.Windows.Forms.Button aButtonSave;
        private System.Windows.Forms.DateTimePicker aDateTimePickerInstalled;
        private System.Windows.Forms.CheckBox aCheckBoxUseDate;
    }
}