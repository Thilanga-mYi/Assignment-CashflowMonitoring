
using CashflowMonitoring;
using CashflowMonitoring.Model;
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
    public partial class AddTransactionView : Form
    {

        public TransactionController TransactionData { get; set; }
        TransactionController enteredTransactions;

        public AddTransactionView()
        {
            InitializeComponent();
            this.loadTransactionTypes();
            this.renderDataTables();
        }

            private void loadTransactionTypes()
        {
            txtTransactionType.Items.Add(new KeyValuePair<String, String>("Income", "1"));
            txtTransactionType.Items.Add(new KeyValuePair<String, String>("Expense", "2"));
            txtTransactionType.DisplayMember = "key";
            txtTransactionType.ValueMember = "value";
        }

        private void renderDataTables()
        {
            CashflowMonitoringData.TransactionDataDataTable data = TransactionController.Instance.GetTransactionData();
            if (data != null)
            {
                this.dtgDataView.DataSource = data;
            }
        }

        private void btnSaveTransactionClick(object sender, EventArgs e)
        {
            TransactionData transaction = new TransactionData();
            transaction.Date = this.txtTransactionDate.Text;
            transaction.Type = this.txtTransactionType.Text;
            transaction.Amount = this.txtTransactionAmount.Text;
            transaction.Reference = this.txtTransactionReference.Text;
            transaction.Name = this.txtTransactionName.Text;

            int val;
            if (int.TryParse(this.txtTransactionAmount.Text, out val))
            {
                TransactionController.Instance.StoreData(transaction);

                CashflowMonitoringData.TransactionDataDataTable transactionData = TransactionController.Instance.GetTransactionData();
                this.dtgDataView.DataSource = transactionData;
            }
            else
            {
                MessageBox.Show("Invalid Data Type for Amount", "Hey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void goBack(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
