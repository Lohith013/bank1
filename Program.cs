using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Bank test = new Bank();
            int IsContinue = 2;
            /*----------------------------Menu---------------*/
            do
            {
                Console.WriteLine("Please select your choice");
                Console.WriteLine("1.Add Account Holder");
                Console.WriteLine("2.Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4.Fund Transfer");
                int Choice = Convert.ToInt32(Console.ReadLine());
                /*             ------ create an new account-------------------------------             */

                switch (Choice)
                {
                    case 1:
                        AccountHolder accountInfo = new AccountHolder();
                        Console.WriteLine("Enter the Account Holder Name");
                        accountInfo.Name = Console.ReadLine();
                        Console.WriteLine("Enter the Account Holder Address");
                        accountInfo.Address = Console.ReadLine();
                        Console.WriteLine("Enter the Account Number");
                        accountInfo.AccountId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Account Type");
                        accountInfo.AccountType = Console.ReadLine();
                        // Console.WriteLine("Enter the Account Balance");
                        // accountInfo.Balance = Convert.ToDecimal(Console.ReadLine());

                        test.AddAccountHolder(accountInfo);

                        //Console.WriteLine(test.AccountHoldersList.Count);
                        //Console.WriteLine(test.AccountHoldersList[0].Balance);
                        break;

                    case 2:
                        /*            ---------------------------- deposit starts here--------------------------------------------            */

                        Console.WriteLine("Enter the account number");
                        int acNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter the amount to be deposited");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());
                        test.Deposit(acNo, amount);

                        break;
                    /*            ---------------------------- deposit   ends here--------------------------------------------            */
                    case 3:
                        /*----------------------------Withdraw starts here----------------*/
                        Console.WriteLine("Enter the account number");
                        int accountNo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter the amount to be withdrawn");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        test.Withdraw(accountNo, withdrawAmount);

                        /*----------------------------Withdraw ends here here----------------*/
                        break;

                    case 4:
                        /*----------------------Fund Transfer starts here----------------------------------*/
                        Sbi sbiobj = new Sbi();

                        Console.WriteLine("enter the bank");
                        string bank = Console.ReadLine();
                        Console.WriteLine("enter the account number from which money to transfered");
                        int AccNo1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the account number which receives amount");
                        int AccNo2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the amount to be transfered");
                        decimal transfreAmount = Convert.ToDecimal(Console.ReadLine());
                        test.FundTransfer(sbiobj, AccNo1, AccNo2, transfreAmount);

                        /*----------------------Fund Transfer ends here----------------------------------*/

                        break;

                    default:
                        Console.WriteLine("Please enter correct option");
                        break;

                }

                Console.WriteLine("Press 1. To continue\n 2.To Exit");
                IsContinue = Convert.ToInt32(Console.ReadLine());
            } while (IsContinue == 1);
            
            Console.ReadLine();
           
        }

    }
}