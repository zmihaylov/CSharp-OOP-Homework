namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(decimal balance, decimal intrestRate, Customer customer)
            : base(balance, intrestRate, customer)
        {

        }

        public override decimal CalculateIntrest(int monthPeriod)
        {
            int period = 0;

            if (this.Customer.GetType().Name == "IndividualCustomer")
            {
                period = 6;

                if (period >= monthPeriod)
                {
                    return 0M;
                }
                else
                {
                    return base.CalculateIntrest(monthPeriod - period);
                }
            }
            else
            {
                period = 12;

                if (period >= monthPeriod)
                {
                    return base.CalculateIntrest(monthPeriod) / 2;
                }
                else
                {
                    return (base.CalculateIntrest(period) / 2) + base.CalculateIntrest(monthPeriod - period);
                }
            }
        }
    }
}
