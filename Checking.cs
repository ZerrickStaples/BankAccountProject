using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Checking: Account
    {
        
        //fields
        
        private string v1;
        private bool v2;

        //properties
        public string name
        {
            get;
            set;
        }

        public string useless
        {
            get;
            set;
        }


        //constructors
        public Checking(string accountType, int accountNum, double balance) : base(accountType, accountNum, balance)
        {
        }


        public Checking(string accountType, int accountNum, double balance, string v1, bool v2) : this(accountType, accountNum, balance)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}

