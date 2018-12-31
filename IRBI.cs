using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    interface IRBI
    {
        void Withdraw(int acNo, decimal amt);
        void Deposit(int acNo, decimal amt);
        void FundTransfer(IRBI b, int acNo1, int acNo2, decimal amt);
    }
}
