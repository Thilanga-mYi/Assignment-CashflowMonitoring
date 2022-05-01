using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashflowMonitoringApp.Model
{
    internal class UserProfileModel
    {
        private String UserNames = null;
        private String Password = null;

        public UserProfileModel()
        {
            this.UserNames = "Thilanga";
            this.Password = "1234";
        }

        internal Boolean LoginUser(String username, String password)
        {
            //access the data
            if (this.UserNames == username  && this.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
