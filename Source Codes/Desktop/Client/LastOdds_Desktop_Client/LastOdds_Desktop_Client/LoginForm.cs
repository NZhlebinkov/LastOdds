using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastOdds_Desktop_Client
{
    public partial class LoginForm : Form
    {
        Point endPoint;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void OnMouseClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPanelMouseDown(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
        }

        private void MainPanelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - endPoint.X;
                this.Top += e.Y - endPoint.Y;
            }
        }

        private void WelcomeLabelMouseDown(object sender, MouseEventArgs e)
        {
            endPoint = new Point(e.X, e.Y);
        }

        private void WelcomeLabelMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - endPoint.X;
                this.Top += e.Y - endPoint.Y;
            }
        }
    }
}
