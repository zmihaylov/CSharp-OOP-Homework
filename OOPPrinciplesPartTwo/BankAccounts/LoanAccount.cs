namespace BankAccounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(decimal balance, decimal intrestRate, Customer customer)
            : base(balance, intrestRate, customer)
        {

        }

        public override decimal CalculateIntrest(int monthPeriod)
        {
            int noIntrestPeriod = 0;

            if (this.Customer.GetType().Name == "IndividualCustomer")
            {
                noIntrestPeriod = 3;
            }
            else
            {
                noIntrestPeriod = 2;
            }

            if (monthPeriod <= noIntrestPeriod)
            {
                return 0M;
            }

            return base.CalculateIntrest(monthPeriod - noIntrestPeriod);
        }
    }
}
