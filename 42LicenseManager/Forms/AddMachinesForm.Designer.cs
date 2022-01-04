namespace _42LicenseManager
{
    partial class AddMachinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMachinesForm));
            this.aButtonSave = new System.Windows.Forms.Button();
            this.aTextBoxMachineName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aLabelDateInstalled = new System.Windows.Forms.Label();
            this.aLabelPcNotes = new System.Windows.Forms.Label();
            this.aTextBoxNotes = new System.Windows.Forms.TextBox();
            this.aDateTimePickerInstalled = new System.Windows.Forms.DateTimePicker();
            this.aButtonCancel = new System.Windows.Forms.Button();
            this.aCheckBoxUseDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // aButtonSave
            // 
            this.aButtonSave.Location = new System.Drawing.Point(307, 255);
            this.aButtonSave.Name = "aButtonSave";
            this.aButtonSave.Size = new System.Drawing.Size(75, 23);
            this.aButtonSave.TabIndex = 5;
            this.aButtonSave.Text = "Save";
            this.aButtonSave.UseVisualStyleBackColor = true;
            this.aButtonSave.Click += new System.EventHandler(this.aButtonSave_Click);
            // 
            // aTextBoxMachineName
            // 
            this.aTextBoxMachineName.Location = new System.Drawing.Point(102, 26);
            this.aTextBoxMachineName.MaxLength = 30;
            this.aTextBoxMachineName.Name = "aTextBoxMachineName";
            this.aTextBoxMachineName.Size = new System.Drawing.Size(361, 20);
            this.aTextBoxMachineName.TabIndex = 1;
            this.aTextBoxMachineName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aTextBoxMachineName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Machines Name:";
            // 
            // aLabelDateInstalled
            // 
            this.aLabelDateInstalled.AutoSize = true;
            this.aLabelDateInstalled.Location = new System.Drawing.Point(20, 55);
            this.aLabelDateInstalled.Name = "aLabelDateInstalled";
            this.aLabelDateInstalled.Size = new System.Drawing.Size(75, 13);
            this.aLabelDateInstalled.TabIndex = 44;
            this.aLabelDateInstalled.Text = "Date Installed:";
            // 
            // aLabelPcNotes
            // 
            this.aLabelPcNotes.AutoSize = true;
            this.aLabelPcNotes.Location = new System.Drawing.Point(58, 82);
            this.aLabelPcNotes.Name = "aLabelPcNotes";
            this.aLabelPcNotes.Size = new System.Drawing.Size(38, 13);
            this.aLabelPcNotes.TabIndex = 64;
            this.aLabelPcNotes.Text = "Notes:";
            // 
            // aTextBoxNotes
            // 
            this.aTextBoxNotes.AcceptsReturn = true;
            this.aTextBoxNotes.Location = new System.Drawing.Point(102, 79);
            this.aTextBoxNotes.Multiline = true;
            this.aTextBoxNotes.Name = "aTextBoxNotes";
            this.aTextBoxNotes.Size = new System.Drawing.Size(361, 170);
            this.aTextBoxNotes.TabIndex = 4;
            // 
            // aDateTimePickerInstalled
            // 
            this.aDateTimePickerInstalled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePickerInstalled.Location = new System.Drawing.Point(102, 52);
            this.aDateTimePickerInstalled.Name = "aDateTimePickerInstalled";
            this.aDateTimePickerInstalled.Size = new System.Drawing.Size(113, 20);
            this.aDateTimePickerInstalled.TabIndex = 2;
            this.aDateTimePickerInstalled.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aDateTimePickerInstalled_KeyPress);
            // 
            // aButtonCancel
            // 
            this.aButtonCancel.Location = new System.Drawing.Point(388, 255);
            this.aButtonCancel.Name = "aButtonCancel";
            this.aButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.aButtonCancel.TabIndex = 6;
            this.aButtonCancel.Text = "Cancel";
            this.aButtonCancel.UseVisualStyleBackColor = true;
            this.aButtonCancel.Click += new System.EventHandler(this.aButtonCancel_Click);
            // 
            // aCheckBoxUseDate
            // 
            this.aCheckBoxUseDate.AutoSize = true;
            this.aCheckBoxUseDate.Checked = true;
            this.aCheckBoxUseDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aCheckBoxUseDate.Location = new System.Drawing.Point(221, 55);
            this.aCheckBoxUseDate.Name = "aCheckBoxUseDate";
            this.aCheckBoxUseDate.Size = new System.Drawing.Size(71, 17);
            this.aCheckBoxUseDate.TabIndex = 3;
            this.aCheckBoxUseDate.Text = "Use Date";
            this.aCheckBoxUseDate.UseVisualStyleBackColor = true;
            this.aCheckBoxUseDate.CheckedChanged += new System.EventHandler(this.ACheckBoxUseDate_CheckedChanged);
            this.aCheckBoxUseDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aCheckBoxUseDate_KeyPress);
            // 
            // AddMachinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 290);
            this.Controls.Add(this.aCheckBoxUseDate);
            this.Controls.Add(this.aButtonCancel);
            this.Controls.Add(this.aDateTimePickerInstalled);
            this.Controls.Add(this.aLabelPcNotes);
            this.Controls.Add(this.aTextBoxNotes);
            this.Controls.Add(this.aLabelDateInstalled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aTextBoxMachineName);
            this.Controls.Add(this.aButtonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMachinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Machines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aButtonSave;
        private System.Windows.Forms.TextBox aTextBoxMachineName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aLabelDateInstalled;
        private System.Windows.Forms.Label aLabelPcNotes;
        private System.Windows.Forms.TextBox aTextBoxNotes;
        private System.Windows.Forms.DateTimePicker aDateTimePickerInstalled;
        private System.Windows.Forms.Button aButtonCancel;
        private System.Windows.Forms.CheckBox aCheckBoxUseDate;
    }
}