namespace SchoolClasses
{
    using System;

    public abstract class People
    {
        private string name;

        public People(string personName)
        {
            this.Name = personName;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null or empty!");
                }
                this.name = value;
            }
        }
    }
}
