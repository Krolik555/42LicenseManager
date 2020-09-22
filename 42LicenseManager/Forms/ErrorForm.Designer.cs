namespace _42Transfer
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            this.aLabelDev = new System.Windows.Forms.Label();
            this.aTextBoxDeveloperMessage = new System.Windows.Forms.TextBox();
            this.aTextBoxUserMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aLabelDev
            // 
            this.aLabelDev.AutoSize = true;
            this.aLabelDev.Location = new System.Drawing.Point(12, 96);
            this.aLabelDev.Name = "aLabelDev";
            this.aLabelDev.Size = new System.Drawing.Size(155, 13);
            this.aLabelDev.TabIndex = 0;
            this.aLabelDev.Text = "Give this error to the developer:";
            // 
            // aTextBoxDeveloperMessage
            // 
            this.aTextBoxDeveloperMessage.Location = new System.Drawing.Point(12, 112);
            this.aTextBoxDeveloperMessage.Multiline = true;
            this.aTextBoxDeveloperMessage.Name = "aTextBoxDeveloperMessage";
            this.aTextBoxDeveloperMessage.ReadOnly = true;
            this.aTextBoxDeveloperMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.aTextBoxDeveloperMessage.Size = new System.Drawing.Size(506, 234);
            this.aTextBoxDeveloperMessage.TabIndex = 2;
            // 
            // aTextBoxUserMessage
            // 
            this.aTextBoxUserMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aTextBoxUserMessage.Location = new System.Drawing.Point(12, 12);
            this.aTextBoxUserMessage.Multiline = true;
            this.aTextBoxUserMessage.Name = "aTextBoxUserMessage";
            this.aTextBoxUserMessage.ReadOnly = true;
            this.aTextBoxUserMessage.Size = new System.Drawing.Size(506, 81);
            this.aTextBoxUserMessage.TabIndex = 3;
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 358);
            this.Controls.Add(this.aTextBoxUserMessage);
            this.Controls.Add(this.aTextBoxDeveloperMessage);
            this.Controls.Add(this.aLabelDev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabelDev;
        private System.Windows.Forms.TextBox aTextBoxDeveloperMessage;
        private System.Windows.Forms.TextBox aTextBoxUserMessage;
    }
}