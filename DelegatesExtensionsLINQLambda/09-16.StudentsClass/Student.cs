namespace _09_16.StudentsClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student
    {
        //Fields
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private List<int> marks;
        private uint groupNumber;

        public Student(string firstName, string lastName, string fn, string tel, string email, uint groupNumber, params int[] inputMarks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.marks = new List<int>(inputMarks);
            this.GroupNumber = groupNumber;
        }

        public Group Group { get; set; }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be null or empty !");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be null or empty !");
                }
                this.lastName = value;
            }
        }

        public string FN
        {
            get { return this.fn; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("FN name can not be null or empty !");
                }
                if (!Regex.IsMatch(value, @"([0-9]{8})"))
                {
                    throw new ApplicationException("Faculty number is a 8 digits number !");
                }
                this.fn = value;
            }
        }

        public string Tel
        {
            get { return this.tel; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Tel name can not be null or empty !");
                }
                if (!Regex.IsMatch(value, @"(\+359[0-9]{9})") && !Regex.IsMatch(value, @"(0[0-9]{9})"))
                {
                    throw new ApplicationException("Telephones begin with +359 / 0 followed by 9 digits !");
                }
                this.tel = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email can not be null or empty !");
                }
                if (!Regex.IsMatch(value, @"[\w., \-]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
                {
                    throw new ApplicationException("Email must be valid !");
                }
                this.email = value;
            }
        }

        public uint GroupNumber
        {
            get { return this.groupNumber; }
            private set
            {
                if (value < 1)
                {
                    throw new ApplicationException("Group number must be > 0 !");
                }
                this.groupNumber = value;
            }
        }

        public List<int> Marks
        {
            get { return this.marks; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            var properties = this.GetType().GetProperties();

            result.AppendLine(new string('-', 40));

            foreach (var property in properties)
            {
                if (property.Name == "Marks" || property.Name == "Group")
                {
                    continue;
                }
                result.AppendFormat("{0}: {1}", property.Name.PadLeft(15), property.GetValue(this, null));
                result.AppendLine();
            }

            result.Append("Marks: ".PadLeft(17));
            result.AppendFormat(string.Join(", ", this.Marks));

            return result.ToString();
        }
    }
}
