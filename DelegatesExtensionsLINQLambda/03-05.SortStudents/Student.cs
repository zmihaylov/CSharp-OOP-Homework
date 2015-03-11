namespace _03_05.SortStudents
{
    using System;

    public struct Student
    {
        public Student(string firstName, string lastName, int age)
            : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Age;
        }
    }
}
