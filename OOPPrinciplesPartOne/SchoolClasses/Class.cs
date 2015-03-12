namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : IComment
    {
        private string uniqueTextIdentifier;
        private List<Student> studentsInClass;
        private List<Teacher> teachingStaff;

        public Class(string textIdentifier, List<Student> students, List<Teacher> teachers)
        {
            this.UniqueTextIdentifier = textIdentifier;
            this.studentsInClass = new List<Student>(students);
            this.teachingStaff = new List<Teacher>(teachers);
            this.Comments = new List<string>();
        }

        public List<Student> StudentsInClass
        {
            get { return this.studentsInClass; }
        }

        public List<Teacher> TeachersTeaching
        {
            get { return this.teachingStaff; }
        }

        public string UniqueTextIdentifier
        {
            get { return this.uniqueTextIdentifier; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Class identifier can not be empty");
                }
                this.uniqueTextIdentifier = value;
            }
        }

        public List<string> Comments { get; private set; }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
