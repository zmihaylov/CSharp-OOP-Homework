namespace BankAccounts
{
    using System;

    public class DepositAccount : Account, IWithdraw
    {
        public DepositAccount(decimal balance, decimal intrestRate, Customer customer)
            : base(balance, intrestRate, customer)
        {

        }

        public override decimal CalculateIntrest(int monthPeriod)
        {
            if (this.Balance < 1000)
            {
                return 0M;
            }
            return base.CalculateIntrest(monthPeriod);
        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Not enough funds!");
            }
            this.Balance -= amount;
        }
    }
}
