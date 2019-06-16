namespace LastOdds_Desktop_Client
{
    partial class LoginForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.registerMenuLabel = new System.Windows.Forms.Label();
            this.loginMenuLabel = new System.Windows.Forms.Label();
            this.loginUserControl = new LastOdds_Desktop_Client.LoginUserControl();
            this.registerUserControl = new LastOdds_Desktop_Client.RegisterUserControl();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.welcomeLabel.Location = new System.Drawing.Point(128, 40);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(271, 60);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "WELCOME";
            this.welcomeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WelcomeLabelMouseDown);
            this.welcomeLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WelcomeLabelMouseMove);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.exitLabel.Location = new System.Drawing.Point(492, 9);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(24, 26);
            this.exitLabel.TabIndex = 1;
            this.exitLabel.Text = "x";
            this.exitLabel.Click += new System.EventHandler(this.OnMouseClick);
            // 
            // registerMenuLabel
            // 
            this.registerMenuLabel.AutoSize = true;
            this.registerMenuLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerMenuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.registerMenuLabel.Location = new System.Drawing.Point(439, 116);
            this.registerMenuLabel.Name = "registerMenuLabel";
            this.registerMenuLabel.Size = new System.Drawing.Size(77, 20);
            this.registerMenuLabel.TabIndex = 3;
            this.registerMenuLabel.Text = "Register";
            this.registerMenuLabel.Click += new System.EventHandler(this.RegisterMenuLabelClick);
            // 
            // loginMenuLabel
            // 
            this.loginMenuLabel.AutoSize = true;
            this.loginMenuLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginMenuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(221)))), ((int)(((byte)(240)))));
            this.loginMenuLabel.Location = new System.Drawing.Point(380, 116);
            this.loginMenuLabel.Name = "loginMenuLabel";
            this.loginMenuLabel.Size = new System.Drawing.Size(53, 20);
            this.loginMenuLabel.TabIndex = 4;
            this.loginMenuLabel.Text = "Login";
            this.loginMenuLabel.Click += new System.EventHandler(this.LoginMenuLabelClick);
            // 
            // loginUserControl
            // 
            this.loginUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.loginUserControl.Location = new System.Drawing.Point(0, 139);
            this.loginUserControl.Name = "loginUserControl";
            this.loginUserControl.Size = new System.Drawing.Size(528, 474);
            this.loginUserControl.TabIndex = 2;
            // 
            // registerUserControl
            // 
            this.registerUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.registerUserControl.Location = new System.Drawing.Point(0, 139);
            this.registerUserControl.Name = "registerUserControl";
            this.registerUserControl.Size = new System.Drawing.Size(528, 474);
            this.registerUserControl.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(528, 613);
            this.Controls.Add(this.registerUserControl);
            this.Controls.Add(this.loginMenuLabel);
            this.Controls.Add(this.registerMenuLabel);
            this.Controls.Add(this.loginUserControl);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LastOdds ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanelMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanelMouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label exitLabel;
        private LoginUserControl loginUserControl;
        private System.Windows.Forms.Label registerMenuLabel;
        private System.Windows.Forms.Label loginMenuLabel;
        private RegisterUserControl registerUserControl;
    }
}

