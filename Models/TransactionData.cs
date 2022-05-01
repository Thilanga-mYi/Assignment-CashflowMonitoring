using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashflowMonitoring.Model
{
    public class TransactionData
    {
        private int id;
        private String date;
        private String type;
        private String amount;
        private String reference;
        private String name;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public String Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
