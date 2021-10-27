
namespace _42LicenseManager.Forms
{
    partial class ConfirmationForm
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
            this.aTextBoxOkay = new System.Windows.Forms.Button();
            this.aTextBoxMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aTextBoxOkay
            // 
            this.aTextBoxOkay.Location = new System.Drawing.Point(81, 59);
            this.aTextBoxOkay.Name = "aTextBoxOkay";
            this.aTextBoxOkay.Size = new System.Drawing.Size(75, 23);
            this.aTextBoxOkay.TabIndex = 0;
            this.aTextBoxOkay.Text = "Okay";
            this.aTextBoxOkay.UseVisualStyleBackColor = true;
            this.aTextBoxOkay.Click += new System.EventHandler(this.aTextBoxOkay_Click);
            // 
            // aTextBoxMsg
            // 
            this.aTextBoxMsg.BackColor = System.Drawing.SystemColors.Control;
            this.aTextBoxMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aTextBoxMsg.Location = new System.Drawing.Point(39, 12);
            this.aTextBoxMsg.Multiline = true;
            this.aTextBoxMsg.Name = "aTextBoxMsg";
            this.aTextBoxMsg.ReadOnly = true;
            this.aTextBoxMsg.Size = new System.Drawing.Size(157, 41);
            this.aTextBoxMsg.TabIndex = 1;
            this.aTextBoxMsg.Text = "Message Here";
            this.aTextBoxMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 95);
            this.Controls.Add(this.aTextBoxMsg);
            this.Controls.Add(this.aTextBoxOkay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aTextBoxOkay;
        private System.Windows.Forms.TextBox aTextBoxMsg;
    }
}