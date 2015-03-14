namespace BankAccounts
{
    using System;

    public abstract class Account : IDeposit, ICalculateIntrest
    {
        private decimal balance;
        private decimal intrestRate;

        public Account(decimal customerBalance, decimal customerIntrestRate,Customer currentCustomer)
        {
            this.Balance = customerBalance;
            this.IntrestRate = customerIntrestRate;
            this.Customer = currentCustomer;
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("This guy owes us money!");
                }
                this.balance = value;
            }
        }

        public decimal IntrestRate
        {
            get { return this.intrestRate; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Intrest can not be a negative value!");
                }
                this.intrestRate = value;
            }
        }

        public Customer Customer { get; private set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArithmeticException("The amount must be a positive decimal number obove zero!");
            }
            this.Balance += amount;
        }

        public virtual decimal CalculateIntrest(int monthPeriod)
        {
            if (monthPeriod <= 0)
            {
                throw new ArithmeticException("The month period must be over zero!");
            }
            return this.IntrestRate * monthPeriod;
        }
    }
}
