namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string disciplineName,int numberOfLectures, int numberOfExercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
            this.Comments = new List<string>();
        }

        public string DisciplineName
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Discipline name can not be null or empty!");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            private set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("Number of lectures can not be negative");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            private set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("Number of exercises can not be negative");
                }
                this.numberOfExercises = value;
            }
        }

        public List<string> Comments { get; private set; }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
