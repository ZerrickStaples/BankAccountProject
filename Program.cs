using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
           string bankName = "Zerrick's Bank";


            string userName = "James Smith";

               
                int AccountNum = 1018;


            Console.WriteLine("Welcome to " + bankName + ", " + userName + "\n" + "Account Number: " + AccountNum);



                Checking CheckingAcct = new Checking("checking", 1018, 100);

                
               Reserve ReserveAcct = new Reserve("reserve", 1018, 500);

                
               Savings SavingsAcct = new Savings("savings", 1018, 1000);

                
                Account JamesSmith = new Account("James Smith");


            //Methods
            do
            {
                StreamWriter transactions = new StreamWriter("transactions.txt");

                using (transactions)
                {


                    JamesSmith.Options();
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "1":
                            JamesSmith.ViewClient();
                            break;

                        case "2":
                            Console.WriteLine("Here are your account balances, " + userName + " .");
                            CheckingAcct.ViewBalance(); SavingsAcct.ViewBalance(); ReserveAcct.ViewBalance();
                            break;

                        case "3":
                            JamesSmith.checkingDeposit();
                            break;

                        case "4":
                            JamesSmith.savingsDeposit();
                            break;

                        case "5":
                            JamesSmith.reserveDeposit();
                            break;

                        case "6":
                            JamesSmith.checkingWithdraw();
                            break;

                        case "7":
                            JamesSmith.savingsWithdraw();
                            break;

                        case "8":
                            JamesSmith.reserveWithdraw();
                            break;

                        case "9":
                            JamesSmith.Exit();
                            break;

                        default:
                            Console.WriteLine("Please enter a valid input");
                            break;
                    }
                }
            }
            while (true);

            }
        }
    }
