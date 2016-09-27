using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Account
    {
        //fields
        string userName = "James Smith";
        private string accountType;
        private int accountNum = 1018;
        private double balance = 100;
        private double balance2 = 500;
        private double balance3 = 1000;
        private string v;
        private char a;
        

        //properties
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = "James Smith"; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public double Balance2
        {
            get { return this.balance2; }
            set { this.balance2 = value; }
            
        }

        public double Balance3
        {
            get { return this.balance3; }
            set { this.balance3 = value; }
        }


        //constructor
        public Account(string accountType, double balance, double balance2, double balance3, int accountNum)
        {
            this.accountType = accountType;
            this.accountNum = accountNum;
            this.balance = balance;
            this.balance2 = balance2;
            this.balance3 = balance3;
        }

        public Account(string accountType, int accountNum, double balance, double balance2, double balance3)
        {
            this.accountType = accountType;
            this.accountNum = accountNum;
            this.balance = balance;
            this.balance2 = balance2;
            this.balance3 = balance3;

        }

        public Account(string v)
        {
            this.v = v;
        }

        public Account(string v, int accountNum, double balance) : this(v)
        {
            this.accountNum = accountNum;
            this.balance = balance;
        }


        //methods

        public void Options()
        {
            Console.WriteLine("Please select an option.\n");
            Console.WriteLine("1. Account Info");
            Console.WriteLine("2. Balances");
            Console.WriteLine("   a. Checking Balance: " + balance);
            Console.WriteLine("   b. Savings Balance: " + balance2);
            Console.WriteLine("   c. Reserve Balance: " + balance3);
            Console.WriteLine("3. Deposit to checking");
            Console.WriteLine("4. Deposit to savings");
            Console.WriteLine("5. Deposit to reserve");
            Console.WriteLine("6. Withdraw from checking");
            Console.WriteLine("7. Withdraw from savings");
            Console.WriteLine("8. Withdraw from reserve");
            Console.WriteLine("9. Quit");
        }


        public void ViewClient()
        {
            Console.WriteLine("Client name: " + userName + accountNum);
        }

        public void ViewBalance()
        {
            Console.WriteLine("Your balance is: " + balance);
        }

        public void checkingDeposit()
        {
            Console.WriteLine("Please enter an amount to deposit into your account.");
            double amount = double.Parse(Console.ReadLine());

            Balance = Balance + amount;
            Console.WriteLine("You now have " + Balance + " in your account.");
        }

        public void savingsDeposit()
        {
            Console.WriteLine("Please enter an amount to deposit into your account.");
            double amount = double.Parse(Console.ReadLine());

            Balance2 = Balance2 + amount;
            Console.WriteLine("You now have " + Balance2 + " in your account.");
        }

        public void reserveDeposit()
        {
            Console.WriteLine("Please enter an amount to deposit into your account.");
            double amount = double.Parse(Console.ReadLine());

            Balance3 = Balance3 + amount;
            Console.WriteLine("You now have " + Balance3 + " in your account.");
        }

        public void checkingWithdraw()
        {
            Console.WriteLine("Please enter an amount to withdraw.");
            double amount = double.Parse(Console.ReadLine());

            Balance = Balance - amount;
            Console.WriteLine(Balance);
        }

        public void savingsWithdraw()
        {
            Console.WriteLine("Please enter an amount to withdraw.");
            double amount = double.Parse(Console.ReadLine());

            Balance2 = Balance2 - amount;
            Console.WriteLine(Balance2);
        }

        public void reserveWithdraw()
        {
            Console.WriteLine("Please enter an amount to withdraw.");
            double amount = double.Parse(Console.ReadLine());

            Balance3 = Balance3 - amount;
            Console.WriteLine(Balance3);
        }

        public void Exit()
        {
            Console.WriteLine("Have a great day.");
            Environment.Exit(0);
        }


        public void DepositAmount()
        {
           Console.WriteLine("Enter amount to deposit.");
           double amount = double.Parse(Console.ReadLine());

           double newBalance = balance - amount;
           Console.WriteLine("You now have " + newBalance + " remaining.");
        }

        public void WithdrawAmount()
        {
            Console.WriteLine("Enter amount to withdraw.");
            double amount = double.Parse(Console.ReadLine());

            double newBalance = balance - amount;
            Console.WriteLine("You now have " + newBalance + " remaining.");
        }

        

        




    }
}
