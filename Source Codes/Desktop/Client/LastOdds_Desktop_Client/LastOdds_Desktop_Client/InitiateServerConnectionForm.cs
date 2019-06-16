using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastOdds_Desktop_Client
{
    public partial class InitiateServerConnectionForm : Form
    {
        public InitiateServerConnectionForm()
        {
            InitializeComponent();           
            InitiateConnection();
            this.Close();
        }

        static void InitiateConnection()
        {
            try
            {

                GlobalVariablesClass.localClient.Connect("127.0.0.1", 1054);
                GlobalVariablesClass.clientNetworkStream = GlobalVariablesClass.localClient.GetStream();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void InitiateServerConnectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
