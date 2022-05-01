using CashflowMonitoring;
using CashflowMonitoring.Views;
using CashflowMonitoringApp.DataObjects;
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
    public partial class DashboardView : Form
    {

        public DashboardView()
        {
            InitializeComponent();
        }

        private void btnAddTransactionView_Click(object sender, EventArgs e)
        {
            AddTransactionView addTransactionView = new AddTransactionView();
            addTransactionView.Show();
            //this.Hide();
        }

        private void btnViewWeeklyReport_Click(object sender, EventArgs e)
        {
            WeeklyReportView weeklyReportView = new WeeklyReportView();
            weeklyReportView.Show();

        }

        private void btnViewFinancialStatus_Click(object sender, EventArgs e)
        {
            FinancialStatusPredictionView financialStatusView = new FinancialStatusPredictionView();
            financialStatusView.Show();
        }
    }
}
