using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Bank : IRBI
    {
        public void Deposit(int acNo, decimal amt)
        {
           foreach(AccountHolder eachaccount in AccountHoldersList)
            {
                if (eachaccount.AccountId == acNo)
                {
                    eachaccount.Balance += amt;
                }

            }

            Console.WriteLine("Amount credited in" + "  " + acNo +"  is " + amt);
        }

        public void FundTransfer(IRBI b, int acNo1, int acNo2, decimal amt)
        {
            foreach(AccountHolder account in AccountHoldersList)
            {
                if(account.AccountId == acNo1)
                {
                    account.Balance -= amt;
                }
            }

            foreach(AccountHolder account in AccountHoldersList)
            {
                if(account.AccountId== acNo2)
                {
                    account.Balance += amt;
                   
                }
            }
            Console.WriteLine("Amount Transferred from  " + acNo1 + "to "+ acNo2 +"is "+ amt );
        }

        public void Withdraw(int acNo, decimal amt)
        {
            foreach(AccountHolder account in AccountHoldersList)
            {
                if( account.AccountId == acNo)
                {
                    account.Balance -= amt;
                }
            }

            Console.WriteLine("Amount debited from  "+ acNo + "is "+ amt);
        }

        public List<AccountHolder> AccountHoldersList = new List<AccountHolder>();

        public void AddAccountHolder(AccountHolder newaccountholderinfo)
        {
       
            AccountHoldersList.Add(newaccountholderinfo);
            Console.WriteLine(newaccountholderinfo.Name+"  "+newaccountholderinfo.AccountId+"  "+newaccountholderinfo.AccountType+"  "+newaccountholderinfo.Balance+"  "+newaccountholderinfo.Address);

        }
        
    }
    
}