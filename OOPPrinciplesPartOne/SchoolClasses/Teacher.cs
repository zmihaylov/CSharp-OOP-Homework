namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People, IComment
    {
        private List<Discipline> setOfDisciplines;

        public Teacher(string name, List<Discipline> setOfDisciplines)
            : base(name)
        {
            this.setOfDisciplines = new List<Discipline>(setOfDisciplines);
            this.Comments = new List<string>();
        }

        public List<Discipline> SetOfDisciplines
        {
            get { return this.setOfDisciplines; } 
        }

        public List<string> Comments { get; private set; }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }
    }
}
