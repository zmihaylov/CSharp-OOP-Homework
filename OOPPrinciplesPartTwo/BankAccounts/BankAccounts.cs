using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class BankAccounts
    {
        static void Main()
        {
            Customer petar = new IndividualCustomer("Petar Gigov", "BG33TTGG99004578652378");
            Customer telerik = new CompanyCustomer("Telerik Academy", "BG44VVZZ88112536748501");

            var petersDepositAcc = new DepositAccount(1500M, 0.06M, petar);
            petersDepositAcc.Deposit(10000);
            Console.WriteLine(petersDepositAcc.Balance);
            petersDepositAcc.Withdraw(5000);
            Console.WriteLine(petersDepositAcc.Balance);
            Console.WriteLine(petersDepositAcc.CalculateIntrest(12));

            var tekeriksLoanAcc = new LoanAccount(100000M, 0.05M, telerik);
            Console.WriteLine(tekeriksLoanAcc.CalculateIntrest(2));

            var teleriksMortgageAcc = new MortgageAccount(250000M, 0.1M, telerik);
            Console.WriteLine(teleriksMortgageAcc.CalculateIntrest(12));
        }
    }
}
