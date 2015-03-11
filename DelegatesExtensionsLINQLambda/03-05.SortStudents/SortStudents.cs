namespace _03_05.SortStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortStudents
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("pesho","peshev",21),
                new Student("maria","petkova",34),
                new Student("pesho","stoqnov",54),
                new Student("sonq","kolqnova",23),
                new Student("polq","pesheva",12),
                new Student("pesho","petrov",20),
                new Student("ivan","toshev",43),
                new Student("gosho","peshev",33),
                new Student("dragan","kirov",18),
                new Student("maria","paraskeva",24),
            };

            //Task 3
            // Lambda and linq
            var sort = students
                .Where(st => st.FirstName.CompareTo(st.LastName) < 0);
            Print(sort);
            Console.WriteLine();

            // Linq only
            var sortLinqOnly =
                from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;
            Print(sortLinqOnly);
            Console.WriteLine();

            // Task 4
            // Lambda and linq
            var sortBetweenAge = students
                .Where(st => st.Age >= 18 && st.Age <= 24);
            Print(sortBetweenAge);
            Console.WriteLine();

            // linq only
            var sortAgainBetweenAge =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select st;
            Print(sortAgainBetweenAge);
            Console.WriteLine();

            // Task 5
            // Lambda and linq
            var sortDescending = students
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName);
            Print(sortDescending);
            Console.WriteLine();

            // linq only
            var sordDescendingAgain =
                from st in students
                orderby st.FirstName descending,
                st.LastName descending
                select st;
            Print(sordDescendingAgain);
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
