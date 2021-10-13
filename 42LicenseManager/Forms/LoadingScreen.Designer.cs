namespace _42LicenseManager.Forms
{
    partial class LoadingScreen
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
            this.aLabelLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aLabelLoading
            // 
            this.aLabelLoading.AutoSize = true;
            this.aLabelLoading.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelLoading.ForeColor = System.Drawing.Color.Black;
            this.aLabelLoading.Location = new System.Drawing.Point(96, 32);
            this.aLabelLoading.Name = "aLabelLoading";
            this.aLabelLoading.Size = new System.Drawing.Size(193, 40);
            this.aLabelLoading.TabIndex = 0;
            this.aLabelLoading.Text = "Loading . . .";
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 161);
            this.Controls.Add(this.aLabelLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.Text = "LoadingScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabelLoading;
    }
}