namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class SchoolClassesMain
    {
        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Moro",12),
                new Student("Goro",6),
                new Student("Filka",13),
                new Student("Cekata ot karlovo",1),
                new Student("Golemc",2),
                new Student("Kichka Bodurova",22),
                new Student("Galin Relefa",3),
            };

            var disciplinesOfGosho = new List<Discipline>()
            {
                new Discipline("OOP",2,6),
                new Discipline("C#",4,12),
            };

            var teacher = new Teacher("Gosho ot pochivka", disciplinesOfGosho);

            var aClass = new Class("A", students, new List<Teacher>() { teacher });
            aClass.AddComment("Very stupid students in this class!");

            Console.WriteLine(aClass.UniqueTextIdentifier);
            Console.WriteLine("Students: ");
            foreach (var student in aClass.StudentsInClass)
            {
                Console.WriteLine(student.Name + " " + student.UniqueClassNumber);
            }

            foreach (var teach in aClass.TeachersTeaching)
            {
                Console.WriteLine(teach.Name + ":");
                foreach (var disc in teach.SetOfDisciplines)
                {
                    Console.WriteLine(disc.DisciplineName + " - " + disc.NumberOfExercises + " - " + disc.NumberOfLectures);
                }
            }

            var telerikAcademy = new School("TelerikAcademy");

            telerikAcademy.AddClass(aClass);

            foreach (var cl in telerikAcademy.ClassesInTheSchool)
            {
                foreach (var com in cl.Comments)
                {
                    Console.WriteLine(com);
                }
            }
        }
    }
}
