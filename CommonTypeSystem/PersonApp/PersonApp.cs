namespace PersonApp
{
    using System;
    public class PersonApp
    {
        public static void Main()
        {
            var ivan = new Person("Ivan");
            var pesho = new Person("Peshi", 23);

            Console.WriteLine(ivan);
            Console.WriteLine(pesho);
        }
    }
}
