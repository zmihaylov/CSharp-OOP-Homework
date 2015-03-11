namespace _18_19.StudentByGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StudentMain
    {
        static void Main()
        {
            var students = GenerateStudent();

            Console.WriteLine(new string('*', 25) + "Using LINQ!" + new string('*', 25));

            var sortByGroup = students
                .GroupBy(st => st.GroupName);

            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var group in sortByGroup)
            {
                var current = new List<string>();
                foreach (var value in group)
                {
                    current.Add(value.Name);
                }

                result.Add(group.Key, string.Join(", ", current));
            }

            foreach (var pair in result)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 25) + "Using Extension!" + new string('*', 25));

            var withExtensionGrouped = students.GroupByGroupName();

            foreach (var group in withExtensionGrouped)
            {
                Console.WriteLine(group);
            }
        }

        static List<Student> GenerateStudent()
        {
            Random rand = new Random();

            string[] names = new string[]
            {
                "Ivan", "Ivanka", "Maria", "Gosho", "Vladimir",
                "Dragomir", "Mitko", "Joro", "Kinka", "Tuturutka", 
                "Kiril", "Mitka", "Katq", "Vasil" 
            };

            string[] groups = new string[]
            {
                "Maths", "Biology", "Law", "ComputerScience", "RoketScience" ,
                "Physics", "Mythology", "Foreign Languages", "Culture"
            };

            var students = new List<Student>();

            for (int i = 0; i < 20; i++)
            {
                students.Add(new Student(names[rand.Next(0, names.Length)],groups[rand.Next(0,groups.Length)]));
            }

            return students;
        }
    }
}
