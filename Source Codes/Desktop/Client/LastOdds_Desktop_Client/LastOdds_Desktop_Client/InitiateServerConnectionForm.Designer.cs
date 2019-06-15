namespace LastOdds_Desktop_Client
{
    partial class InitiateServerConnectionForm
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
            this.initLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // initLabel
            // 
            this.initLabel.AutoSize = true;
            this.initLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initLabel.Location = new System.Drawing.Point(77, 84);
            this.initLabel.Name = "initLabel";
            this.initLabel.Size = new System.Drawing.Size(179, 48);
            this.initLabel.TabIndex = 0;
            this.initLabel.Text = "Initiating Connection\r\n      Please Wait\r\n";
            // 
            // InitiateServerConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 212);
            this.Controls.Add(this.initLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InitiateServerConnectionForm";
            this.Text = "Initiating Server Connection";
            this.Load += new System.EventHandler(this.InitiateServerConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initLabel;
    }
}