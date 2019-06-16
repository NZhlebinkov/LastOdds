using System;
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
    public partial class RegisterUserControl : UserControl
    {
        public RegisterUserControl()
        {
            InitializeComponent();
            showPasswordCheckBox.CheckState = CheckState.Checked;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text !=repeatedPasswordTextBox.Text)
            {
                MessageBox.Show("Password is not the same");
            }
            else
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                AccountOperationsClass.Register(username, password);
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.CheckState != CheckState.Checked)
            {
                passwordTextBox.PasswordChar = '*';
                repeatedPasswordTextBox.PasswordChar = '*';
            }
            else
            {
                passwordTextBox.PasswordChar = '\0';
                repeatedPasswordTextBox.PasswordChar = '\0';
            }
        }
    }
}
