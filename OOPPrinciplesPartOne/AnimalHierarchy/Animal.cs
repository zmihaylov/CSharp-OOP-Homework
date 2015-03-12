namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal
    {
        private string name;
        private int age;
        private Gender sex;

        public Animal(string name, int age)
            : this(name, age, Gender.male)
        {

        }

        public Animal(string name, int age, Gender sex)
        {
            this.Sex = sex;
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be empty");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentException("Invalid age! (must be between 0 and 20 including)");
                }
                this.age = value;
            }
        }

        public Gender Sex
        {
            get { return this.sex; }
            protected set { this.sex = value; }
        }

        public static IEnumerable<Tuple<string,double>> AverageAge(IEnumerable<Animal> animals)
        {
            var average = animals
                .GroupBy(an => an.GetType())
                .Select(an => new Tuple<string, double>(an.Key.Name, an.Average(a => a.Age)));

            return average;
        }
    }
}
