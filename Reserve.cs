using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Reserve:Account
    {
        
        //Inherit base class
        private string v1;
        private bool v2;

        //properties
        public string Name
        {
            get;
            set;
        }


        //constructors
        public Reserve (string accountType, int accountNum, double balance2) : base(accountType, accountNum, balance2)
        {
        
        }


        public Reserve(string accountType, int accountNum, double balance2, string v1, bool v2) : this (accountType, accountNum, balance2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

    }
}
