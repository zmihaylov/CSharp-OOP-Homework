namespace AbstractHuman
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string first,string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name is not correct!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name is not correct!");
                }
                this.lastName = value;
            }
        }
    }
}
