namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Student : People, IComment
    {
        private int uniqueClassNumber;

        public Student(string name, int uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
            this.Comments = new List<string>();
        }

        public int UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            private set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("Unique class number can not be negative!");
                }
                this.uniqueClassNumber = value;
            }
        }

        public List<string> Comments { get; private set; }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
