namespace StudentInfo
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class Student : IComparable<Student>, ICloneable
    {
        // Fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string address;
        private string phone;
        private string email;
        private int course;

        public Student(string firName, string midName, string lasName, 
            string socialNumber, string address, string phone,
            string email,int courseYear, University university,
            Faculty faculty, Specialty specialty)
        {
            this.FirstName = firName;
            this.MiddleName = midName;
            this.LastName = lasName;
            this.SSN = socialNumber;
            this.Address = address;
            this.PhoneNumber = phone;
            this.course = courseYear;
            this.Email = email;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        // Properties
        public Faculty Faculty { get; set; }
        public University University { get; set; }
        public Specialty Specialty { get; set; }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("First name can not be empty");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Middle name can not be empty");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Last name can not be empty");
                }
                this.lastName = value;
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Address can not be empty");
                }
                this.address = value;
            }
        }

        public string PhoneNumber
        {
            get { return this.phone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Tel name can not be null or empty !");
                }
                if (!Regex.IsMatch(value, @"(\+359[0-9]{9})") && !Regex.IsMatch(value, @"(0[0-9]{9})"))
                {
                    throw new ApplicationException("Telephones begin with +359 / 0 followed by 9 digits !");
                }
                this.phone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (!CheckIfValidEmail(value))
                {
                    throw new ArgumentException("Email is not correct");
                }
                this.email = value;
            }
        }

        public int Course
        {
            get { return this.course; }
            set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentException("Invalid course");
                }
                this.course = value;
            }
        }

        public string SSN
        {
            get { return this.ssn; }
            set
            {
                if (value == null || !value.All(n => char.IsDigit(n)) || value.Length != 10)
                {
                    throw new ArgumentException("Invalid SSN");
                }
                this.ssn = value;
            }
        }
        // Methods

        private bool CheckIfValidEmail(string currentEmail)
        {
            if (currentEmail == null)
            {
                return false;
            }

            return Regex.IsMatch(currentEmail,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Student;

            if (other == null)
            {
                throw new ArgumentException("Passed object is not Student");
            }

            if (this.FirstName == other.FirstName && this.MiddleName == other.MiddleName && this.LastName == other.LastName)
            {
                if (this.SSN == other.SSN)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator ==(Student first, Student second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !object.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode()
                   ^ this.MiddleName.GetHashCode()
                   ^ this.LastName.GetHashCode()
                   ^ this.SSN.GetHashCode();
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.MiddleName + " " + this.LastName + " " + this.SSN + "\n" + 
                this.Address + " " + this.PhoneNumber + " " + this.Email + " " + this.Course + "\n" +
                this.University + " " + this.Faculty + " " + this.Specialty;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName == other.FirstName && this.MiddleName == other.MiddleName && this.LastName == other.LastName)
            {
                return ulong.Parse(this.SSN).CompareTo(ulong.Parse(other.SSN));
            }
            else
            {
                return (this.FirstName + this.MiddleName + this.LastName).CompareTo(other.FirstName + other.MiddleName + other.LastName);
            }
        }

        public object Clone()
        {
            // I use MemberwiseClone because all fields and properties are value type so everything will clone correctly
            return this.MemberwiseClone();
        }
    }
}
