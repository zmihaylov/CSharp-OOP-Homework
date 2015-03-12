namespace AbstractHuman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AbstractHumanMain
    {
        static void Main()
        {
            var aClass = new List<Student>()
            {
                new Student("Gaco","Baco",2),
                new Student("Sharo","Baro",3),
                new Student("Don","Corleone",4),
                new Student("Bachi","Kiko",6),
                new Student("Joro","Ot Pochivka",3),
                new Student("Dan","Bilzerian",4),
                new Student("Eli","Kuchkova",5),
                new Student("Boko","Tikvata",3),
                new Student("Galq","Ot Saten",6),
                new Student("Niki","Kitaeca",2),
            };

            var sortedStudents = aClass
                .OrderBy(s => s.Grade);

            foreach (var stud in sortedStudents)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine();

            var workers = new List<Worker>()
            {
                new Worker("Pesho","Peshev",1110,8),
                new Worker("Ivo","Ivanov",800,8),
                new Worker("Georgi","Georgiev",987,6),
                new Worker("Joro","Jorev",456,8),
                new Worker("Vasil","Vasilev",1500,8),
                new Worker("Denis","Penis",660,6),
                new Worker("Barak","Obama",325,2),
                new Worker("Sofia","Pernik",2900,12),
                new Worker("Ivaylo","Kenov",1280,10),
                new Worker("Stefan","Sofianski",350,4)
            };

            var sortedWorker = workers
                .OrderByDescending(w => w.MoneyPerHour());

            foreach (var work in sortedWorker)
            {
                Console.WriteLine(work);
            }
            Console.WriteLine();

            List<Human> merge = new List<Human>(workers);

            foreach (var stud in aClass)
            {
                merge.Add(stud);
            }

            var sortedAll = merge
                .OrderBy(m => m.FirstName)
                .ThenBy(m => m.LastName);

            foreach (var hum in sortedAll)
            {
                Console.WriteLine(hum);
            }
        }
    }
}
