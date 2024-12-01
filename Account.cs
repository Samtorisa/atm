using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankApp
{
    public class Account
    {
        private int accountId;
        private string accountName;
        private double balance;
        private Person person;

        


        public Account() { }

        public Account(string accountName,double balance,Person person)
        {
            this.accountName = accountName;
            this.balance= balance;
            this.person = person;

        }
    
    }
}
