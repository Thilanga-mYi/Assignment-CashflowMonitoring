using CashflowMonitoring;
using CashflowMonitoring.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CashflowMonitoringApp.DataObjects
{
    public class TransactionController
    {

        CashflowMonitoringData dbData = new CashflowMonitoringData();

        private static TransactionController instance = null;
        public static TransactionController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TransactionController();
                }
                return instance;
            }
        }

        public void StoreData(TransactionData transactions) {

            CashflowMonitoringData.TransactionDataRow row = this.dbData.TransactionData.NewTransactionDataRow();
            if (transactions != null)
            {
                row.Date = transactions.Date;
                row.Type = transactions.Type;
                row.Amount = transactions.Amount;
                row.Reference = transactions.Reference;
                row.Name = transactions.Name;
                this.dbData.TransactionData.AddTransactionDataRow(row);
            }
        }

        public CashflowMonitoringData.TransactionDataDataTable GetTransactionData()
        {
            return this.dbData.TransactionData;
        }

        public CashflowMonitoringData.TransactionDataDataTable GenerateWeeklyReport(DateTime startDate, DateTime endDate)
        {
            CashflowMonitoringData.TransactionDataDataTable rows = this.dbData.TransactionData;
            var filteredRows = rows.Select("#" + startDate + "# <= Date AND Date <= #" + endDate + "#");

            CashflowMonitoringData.TransactionDataDataTable filteredTransactions = new CashflowMonitoringData.TransactionDataDataTable();
            filteredRows.ToList().ForEach(row => filteredTransactions.ImportRow(row));

            return filteredTransactions;
        }
    
        public List<double> GetExpensesList()
        {
            CashflowMonitoringData.TransactionDataDataTable rows = this.dbData.TransactionData;
            List<CashflowMonitoringData.TransactionDataRow> expenseRow = rows.Where(row => row.Type == "Expense").ToList();

            List<double> expenses = new List<double>(expenseRow.Count);
            expenses.AddRange(expenseRow.Select(transaction => double.Parse(transaction.Amount)));
            return expenses;
        }

    }
}
