namespace _09_16.StudentsClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsMain
    {
        public static List<Student> students = new List<Student>()
        {
            new Student("Bobi", "Turboto", "23361406","0299923499", "bobi@abv.bg", 2,2, 2, 2, 5, 4, 1),
            new Student("Genka", "Shikerova", "11221105", "+359212345123", "wholetthedogsout@gbg.bg", 2,1, 1, 1, 1),
            new Student("Gosho", "Trankarq", "23361406","+359877223444", "whatisthis@abv.bg", 2,6, 6, 6, 3),
            new Student("Kata", "Mincheva", "12340608","+359874334144", "tellmeasecret@gmail.bg", 3, 6, 6, 6, 4, 6, 1),
            new Student("Mincho", "Praznikov", "82123444","07333441114", "whereareyou@abv.bg", 3,2, 2,3,4),
            new Student("Zakojto", "Sesetish", "14514506","+359215554442", "kajichesno@abv.bg", 2,6, 6, 6, 4, 6, 1),
            new Student("Kate", "Dobreva", "12340608","+359874235542", "biftek@gmail.bg", 3, 2, 2, 3, 4, 3, 1)
        };

        static void Main()
        {
            //Undo comment to see results!!!!

            //Task9();
            //Task10();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            //Task15();
            //Task16();
        }

        private static void Task16()
        {
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Physics"),
                new Group(2, "Mathematics"),
                new Group(3, "Maths"),
                new Group(4, "Computer Science"),
                new Group(5, "Medicine"),
                new Group(6, "Biology"),
            };

            var studentsFromMathematics = students
                .Join(groups, st => st.GroupNumber, gr => gr.GroupNumber,
                (st, gr) => new
                {
                    Student = st,
                    Group = gr,
                })
                .Where(mat => mat.Group.DepartmentName == "Mathematics");

            foreach (var st in studentsFromMathematics)
            {
                Console.WriteLine(st);
            }
        }

        private static void Task15()
        {
            var enrolledIn2006Marks = students
                .Where(st => st.FN.Substring(4, 2) == "06");

            foreach (var st in enrolledIn2006Marks)
            {
                Console.WriteLine(string.Join(", ",st.Marks));
            }
        }

        private static void Task14()
        {
            var exactMarkTwoTimes = students.GetStudentWithMarkExactTimes(2, 2);
            Print(exactMarkTwoTimes);
        }

        private static void Task13()
        {
            var atLeastOne6 = students
                .Where(st => st.Marks.Contains(6))
                .Select(st => new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Marks = st.Marks
                });

            foreach (var st in atLeastOne6)
            {
                Console.WriteLine(st.FullName + "'s marks: " + string.Join(", ",st.Marks));
            }
        }

        private static void Task12()
        {
            var fromSofia = students
                .Where(st => st.Tel.StartsWith("+3592") || st.Tel.StartsWith("02"));
            Print(fromSofia);
        }

        private static void Task11()
        {
            var studentsWithEmailInABV = students
                .Where(st => st.Email.Contains("abv.bg"));

            Print(studentsWithEmailInABV);
        }

        private static void Task10()
        {
            var studentsFromGroup = students.GetStudentsFromGroup(2);
            Print(studentsFromGroup);
        }

        private static void Task9()
        {
            var studentsFromGroupTwo = students
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);
            Print(studentsFromGroupTwo);
        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st);
            }
        }
    }
}
