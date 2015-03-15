namespace StudentInfo
{
    using System;
    public class StudentInfo
    {
        static void Main()
        {
            Student IvanPetrov = new Student("Ivan", "Todorov", "Petrov", "8012105421", "somewhere", 
                "0888123456789", "someEmail@abv.bg", 3, University.SU, Faculty.PhisicsFaculty, Specialty.Physics);
            Student StoyanIvanov = new Student("Stoyan", "Todorov", "Ivanov", "7810126428", "Kiten",
                "0777777777777", "golemec@gmail.com", 4, University.UNSS, Faculty.ComputerScienceFaculty, Specialty.Telecommunications);
            Student Stoyan = new Student("Stoyan", "Todorov", "Ivanov", "7810126428", "Kiten",
                "0777777777777", "golemec@gmail.com", 4, University.UNSS, Faculty.ComputerScienceFaculty, Specialty.Telecommunications);

            Console.WriteLine(StoyanIvanov.Equals(Stoyan));
            Console.WriteLine(object.Equals(IvanPetrov,StoyanIvanov));

            Console.WriteLine(IvanPetrov == StoyanIvanov);
            Console.WriteLine(StoyanIvanov == Stoyan);
            Console.WriteLine(IvanPetrov != StoyanIvanov);
            Console.WriteLine(StoyanIvanov != Stoyan);

            Student newStudent = IvanPetrov.Clone() as Student;
            newStudent.Specialty = Specialty.ComputerScience;

            Console.WriteLine(IvanPetrov.Specialty);
            Console.WriteLine(newStudent.Specialty);

            Console.WriteLine(IvanPetrov);
        }
    }
}
