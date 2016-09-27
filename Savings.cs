using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Savings: Account
    {
        
        
        private string v1;
        private bool v2;

        //Minimum 2 properties
        public string Name
        {
            get;
            set;
        }


        //Minimum 1 constructor 
        public Savings (string accountType, int accountNum, double balance3) : base(accountType, accountNum, balance3)
        {
        }


        public Savings (string accountType, int accountNum, double balance3, string v1, bool v2) : this(accountType, accountNum, balance3)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
