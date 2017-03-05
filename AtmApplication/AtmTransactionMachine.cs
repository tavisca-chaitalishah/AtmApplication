using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApplication
{
    class AtmTransactionMachine
    {

        int amount = 1000;
        public void UserTranscation()
        {
            String userPin;
            int choice;
            String userChoiceToContinue;
            Console.WriteLine("Enter your Pin ");
            userPin = Console.ReadLine();

            do
            {
                Console.WriteLine("********Welcome to ATM Service************** \n 1.Check Balance \n 2.Withdraw Cash \n 3.Deposit Cash \n 4.Quit \n*********************************************");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        CheckBalance();
                        break;
                    case 2:

                        CashWithdrawal();
                        break;
                    case 3:

                        CashToDeposit();
                        break;
                    case 4:
                        Console.WriteLine("Thankyou");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine("Enter Y to continue");
                userChoiceToContinue = Console.ReadLine();


            } while (userChoiceToContinue == "Y" || userChoiceToContinue == "y");

            Console.ReadKey();
        }

        void CheckBalance()
        {
            Console.WriteLine("Your Balance is " + amount);
        }
        void CashWithdrawal()
        {
            Console.WriteLine("Enter the Amount to withdraw");
            int amountToWithdraw = Convert.ToInt32(Console.ReadLine());
            amount = amount - amountToWithdraw;
            Console.WriteLine("Your current balance is " + amount);
        }

        void CashToDeposit()
        {
            Console.WriteLine("Enter amount to be Deposited");
            int amountToDeposit = Convert.ToInt32(Console.ReadLine());
            amount = amount + amountToDeposit;
            Console.WriteLine("Your current balance is " + amount);
        }
    }

}

