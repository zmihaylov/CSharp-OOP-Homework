namespace PersonApp
{
    using System;
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name can not be null");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get { return this.age; }
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return this.Name + ", age is not specified";
            }
            return this.Name + " - " + this.Age;
        }
    }
}
