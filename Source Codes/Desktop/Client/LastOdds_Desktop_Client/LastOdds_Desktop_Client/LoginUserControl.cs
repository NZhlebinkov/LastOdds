﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastOdds_Desktop_Client
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
            showPasswordCheckBox.CheckState = CheckState.Checked;
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.CheckState != CheckState.Checked)
            {
                passwordTextBox.PasswordChar = '*';
            }
            else
            {
                passwordTextBox.PasswordChar = '\0';
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            AccountOperationsClass.Login(username, password);
        }
    }
}
