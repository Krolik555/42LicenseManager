
namespace _42LicenseManager.Forms
{
    partial class PendingActionForm
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
            this.aLabelMessage = new System.Windows.Forms.Label();
            this.aLabelAnimation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aLabelMessage
            // 
            this.aLabelMessage.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelMessage.Location = new System.Drawing.Point(12, 9);
            this.aLabelMessage.Name = "aLabelMessage";
            this.aLabelMessage.Size = new System.Drawing.Size(360, 125);
            this.aLabelMessage.TabIndex = 0;
            this.aLabelMessage.Text = "Message";
            this.aLabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aLabelAnimation
            // 
            this.aLabelAnimation.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelAnimation.Location = new System.Drawing.Point(122, 136);
            this.aLabelAnimation.Name = "aLabelAnimation";
            this.aLabelAnimation.Size = new System.Drawing.Size(147, 41);
            this.aLabelAnimation.TabIndex = 1;
            this.aLabelAnimation.Text = "Animation";
            this.aLabelAnimation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PendingActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 186);
            this.Controls.Add(this.aLabelAnimation);
            this.Controls.Add(this.aLabelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PendingActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PendingActionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aLabelMessage;
        private System.Windows.Forms.Label aLabelAnimation;
    }
}