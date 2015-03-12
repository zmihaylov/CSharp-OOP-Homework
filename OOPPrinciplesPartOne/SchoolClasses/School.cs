namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private List<Class> classesInSchool = new List<Class>();

        public School(string schoolName)
        {
            this.SchoolName = schoolName;
        }

        public List<Class> ClassesInTheSchool
        {
            get { return this.classesInSchool; }
        }

        public string SchoolName
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("School name can not be empty!");
                }
                this.name = value;
            }
        }

        public void AddClass(Class classToAdd)
        {
            this.classesInSchool.Add(classToAdd);
        }

        public void ClassGraduate(Class graduatingClass)
        {
            this.classesInSchool.Remove(graduatingClass);
        }
    }
}
