using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class AnimalHierarchyMain
    {
        static void Main()
        {
            Dog dog = new Dog("Emi", 1, Gender.female);
            Console.WriteLine("{0} says: {1}", dog.Name, dog.MakeSound());
            Frog frog = new Frog("Ram", 3);
            Console.WriteLine("{0} says: {1}", frog.Name, frog.MakeSound());
            Tomcat tomcat = new Tomcat("Tom", 5);
            Console.WriteLine(tomcat.Sex);
            Console.WriteLine("{0} says: {1}", tomcat.Name, tomcat.MakeSound());
            Kitten kitty = new Kitten("Kitty", 2);
            Console.WriteLine("{0} says: {1}", kitty.Name, kitty.MakeSound());
            Console.WriteLine(kitty.Sex);

            Animal[] animals =
            {
                new Dog("Balkan", 3),
                new Cat("Sindy", 2),
                new Tomcat("Bob", 10),
                new Dog("Shako", 11),
                new Frog("Bogy", 4),
                new Frog("Taro", 7),
                new Dog("Baro", 0),
                new Cat("Jaffy", 18),
                new Tomcat("Kosta", 5),
                new Dog("Huskvarna", 7),
                new Dog("Bobcho", 5),
                new Tomcat("Kingo", 8),
                new Kitten("Kitty", 3),
                new Kitten("Cait", 7),
                new Frog("Ram", 3)
            };

            var averageAges = Animal.AverageAge(animals);

            foreach (var animal in averageAges)
            {
                Console.WriteLine(animal.Item1 + " - " + animal.Item2);
            }
        }
    }
}
