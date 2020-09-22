namespace _42LicenseManager.Forms
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
            this.aLabelMsg = new System.Windows.Forms.Label();
            this.aButton1 = new System.Windows.Forms.Button();
            this.aButton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aButton3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabelMsg
            // 
            this.aLabelMsg.Location = new System.Drawing.Point(85, 9);
            this.aLabelMsg.Name = "aLabelMsg";
            this.aLabelMsg.Size = new System.Drawing.Size(399, 149);
            this.aLabelMsg.TabIndex = 0;
            this.aLabelMsg.Text = "Error Message";
            this.aLabelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aButton1
            // 
            this.aButton1.Location = new System.Drawing.Point(367, 171);
            this.aButton1.Name = "aButton1";
            this.aButton1.Size = new System.Drawing.Size(113, 23);
            this.aButton1.TabIndex = 1;
            this.aButton1.Text = "button1";
            this.aButton1.UseVisualStyleBackColor = true;
            this.aButton1.Visible = false;
            this.aButton1.Click += new System.EventHandler(this.AButton1_Click);
            // 
            // aButton2
            // 
            this.aButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.aButton2.Location = new System.Drawing.Point(248, 171);
            this.aButton2.Name = "aButton2";
            this.aButton2.Size = new System.Drawing.Size(113, 23);
            this.aButton2.TabIndex = 2;
            this.aButton2.Text = "button2";
            this.aButton2.UseVisualStyleBackColor = true;
            this.aButton2.Visible = false;
            this.aButton2.Click += new System.EventHandler(this.AButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_42LicenseManager.Properties.Resources.warning_147699_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // aButton3
            // 
            this.aButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aButton3.Location = new System.Drawing.Point(129, 171);
            this.aButton3.Name = "aButton3";
            this.aButton3.Size = new System.Drawing.Size(113, 23);
            this.aButton3.TabIndex = 6;
            this.aButton3.Text = "button3";
            this.aButton3.UseVisualStyleBackColor = true;
            this.aButton3.Visible = false;
            this.aButton3.Click += new System.EventHandler(this.AButton3_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(496, 208);
            this.ControlBox = false;
            this.Controls.Add(this.aButton3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aButton2);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aLabelMsg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning!";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aLabelMsg;
        private System.Windows.Forms.Button aButton1;
        private System.Windows.Forms.Button aButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button aButton3;
    }
}