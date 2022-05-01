using CashflowMonitoringApp.DataObjects;
using CashflowMonitoringApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashflowMonitoringApp
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void AuthenticateUser(object sender, EventArgs e)
        {

            String username = this.txtUserName.Text;
            String password = this.txtPassword.Text;

            //User Validation
            if (username == null || username == String.Empty)
            {
                MessageBox.Show("Username Required", "Hey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserProfileModel userProfileModel = new UserProfileModel();
            Boolean result = userProfileModel.LoginUser(username, password);

            if (result == true)
            {
                DashboardView dashboardView = new DashboardView();
                dashboardView.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Credentials : Hint (Username = Thilanga, Password = 1234)", "Hey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



        }
    }
}
