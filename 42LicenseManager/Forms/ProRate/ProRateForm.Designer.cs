
namespace _42LicenseManager.Forms.ProRate
{
    partial class ProRateForm
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
            this.aDGVTable = new System.Windows.Forms.DataGridView();
            this.aButtonAdd = new System.Windows.Forms.Button();
            this.aButtonCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aDTPickerOldExpiration = new System.Windows.Forms.DateTimePicker();
            this.aDTPickerNewExpiration = new System.Windows.Forms.DateTimePicker();
            this.aLabelDesiredExpiration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aDGVTable)).BeginInit();
            this.SuspendLayout();
            // 
            // aDGVTable
            // 
            this.aDGVTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aDGVTable.Location = new System.Drawing.Point(12, 71);
            this.aDGVTable.Name = "aDGVTable";
            this.aDGVTable.Size = new System.Drawing.Size(523, 189);
            this.aDGVTable.TabIndex = 0;
            // 
            // aButtonAdd
            // 
            this.aButtonAdd.Location = new System.Drawing.Point(256, 44);
            this.aButtonAdd.Name = "aButtonAdd";
            this.aButtonAdd.Size = new System.Drawing.Size(34, 21);
            this.aButtonAdd.TabIndex = 1;
            this.aButtonAdd.Text = "Add";
            this.aButtonAdd.UseVisualStyleBackColor = true;
            this.aButtonAdd.Click += new System.EventHandler(this.aButtonAdd_Click);
            // 
            // aButtonCalculate
            // 
            this.aButtonCalculate.Location = new System.Drawing.Point(228, 291);
            this.aButtonCalculate.Name = "aButtonCalculate";
            this.aButtonCalculate.Size = new System.Drawing.Size(83, 21);
            this.aButtonCalculate.TabIndex = 4;
            this.aButtonCalculate.Text = "Calculate";
            this.aButtonCalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Install date/Current Expiration Date:";
            // 
            // aDTPickerOldExpiration
            // 
            this.aDTPickerOldExpiration.Location = new System.Drawing.Point(25, 45);
            this.aDTPickerOldExpiration.Name = "aDTPickerOldExpiration";
            this.aDTPickerOldExpiration.Size = new System.Drawing.Size(225, 20);
            this.aDTPickerOldExpiration.TabIndex = 6;
            // 
            // aDTPickerNewExpiration
            // 
            this.aDTPickerNewExpiration.Location = new System.Drawing.Point(22, 292);
            this.aDTPickerNewExpiration.Name = "aDTPickerNewExpiration";
            this.aDTPickerNewExpiration.Size = new System.Drawing.Size(200, 20);
            this.aDTPickerNewExpiration.TabIndex = 7;
            // 
            // aLabelDesiredExpiration
            // 
            this.aLabelDesiredExpiration.AutoSize = true;
            this.aLabelDesiredExpiration.Location = new System.Drawing.Point(22, 273);
            this.aLabelDesiredExpiration.Name = "aLabelDesiredExpiration";
            this.aLabelDesiredExpiration.Size = new System.Drawing.Size(107, 13);
            this.aLabelDesiredExpiration.TabIndex = 8;
            this.aLabelDesiredExpiration.Text = "New Expiration Date:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 9;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Licenses";
            // 
            // ProRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aLabelDesiredExpiration);
            this.Controls.Add(this.aDTPickerNewExpiration);
            this.Controls.Add(this.aDTPickerOldExpiration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aButtonCalculate);
            this.Controls.Add(this.aButtonAdd);
            this.Controls.Add(this.aDGVTable);
            this.Name = "ProRateForm";
            this.ShowIcon = false;
            this.Text = "Pro Rate licenses";
            ((System.ComponentModel.ISupportInitialize)(this.aDGVTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aDGVTable;
        private System.Windows.Forms.Button aButtonAdd;
        private System.Windows.Forms.Button aButtonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker aDTPickerOldExpiration;
        private System.Windows.Forms.DateTimePicker aDTPickerNewExpiration;
        private System.Windows.Forms.Label aLabelDesiredExpiration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}