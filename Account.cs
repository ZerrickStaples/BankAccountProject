using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        //fields
        List<string> transactions = new List<string>;
        public string userName;
        public double checking;
        public double savings;
        public double reserve;

        //properties
        public string UserName
        {
            get {return this.userName; }
            set {this.userName = value}
        }
        public double Checking
        {
            get { return this.checking; }
            set { this.checking = value; }
        }

        //constructors

        //methods
        public void DepositAmount()
        {
            double putIn = 0;
            checking += putIn;
            transactions.Add("There was " + putIn + "added to account.");
        }

        public void bankHistory()
        {
            
        }

        private void Balance (bool display)
        {
            if (display)
            {
                Console.WriteLine("The total balance is " + );           
            }
        }

        




    }
}
