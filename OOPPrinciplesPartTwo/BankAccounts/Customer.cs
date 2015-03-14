namespace BankAccounts
{
    using System;

    public abstract class Customer
    {
        private string name;
        private string iban;

        public Customer(string customerName, string customerIBAN)
        {
            this.Name = customerName;
            this.IBAN = customerIBAN;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Customer name is incorrect!");
                }
                this.name = value;
            }
        }

        public string IBAN
        {
            get { return this.iban; }
            private set
            {
                if (value.Length != 22)
                {
                    throw new ArgumentException("Invalid IBAN!");
                }
                this.iban = value;
            }
        }
    }
}
