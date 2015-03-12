namespace AbstractHuman
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int studentGrade)
            : base(firstName, lastName)
        {
            this.Grade = studentGrade;
        }

        public int Grade
        {
            get { return this.grade; }
            private set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Invalid grade!");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + this.Grade;
        }
    }
}
