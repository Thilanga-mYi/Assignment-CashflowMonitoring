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

namespace CashflowMonitoring.Views
{
    public partial class FinancialStatusPredictionView : Form
    {
        public FinancialStatusPredictionView()
        {
            InitializeComponent();
        }

        private void btnGetFinancialStatus(object sender, EventArgs e)
        {

            List<double> expenseList = TransactionController.Instance.GetExpensesList();
            double expenseSum = expenseList.Sum();
            double dayCount = 30;
            double expenseAvg = expenseSum / dayCount;

            this.lblTotalAmount.Text = "LKR. "+expenseSum.ToString();
            this.lblAvgAmount.Text = "LKR. " + expenseAvg.ToString();

        }
    }
}
