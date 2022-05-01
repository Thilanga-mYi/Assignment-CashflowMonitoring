using CashflowMonitoringApp;
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

namespace CashflowMonitoring
{
    public partial class WeeklyReportView : Form
    {
        public WeeklyReportView()
        {
            InitializeComponent();
            this.renderEndDate();
        }

        private void changedStartDateValue(object sender, EventArgs e)
        {
            DateTimePicker startDate = (DateTimePicker)sender;
            this.txtEndDate.Value = startDate.Value.AddDays(7);
        }

        private void renderEndDate()
        {
            this.txtStartDate.Value = DateTime.Now;
            this.txtEndDate.Value = DateTime.Now.AddDays(7);
            this.txtEndDate.Enabled = false;
        }

        private void generateWeeklyReport(object sender, EventArgs e)
        {
            DateTime startDate = this.txtStartDate.Value;
            DateTime endDate = this.txtEndDate.Value;

            CashflowMonitoringData.TransactionDataDataTable rows = TransactionController.Instance.GenerateWeeklyReport(startDate, endDate);

            if (rows != null)
            {
                this.dtgWeeklyTransactions.DataSource = rows;
            }
        }
    }
}
