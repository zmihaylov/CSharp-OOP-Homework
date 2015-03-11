namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LongestString
    {
        public static int longestString = 0;
        static void Main()
        {
            var strings = GenerateStrings();

            var result = strings.Max(s => s.Length);

            Console.WriteLine(result);
        }

        static string[] GenerateStrings()
        {
            Random rand = new Random();

            string[] arrayOfStrings = new string[rand.Next(10, 31)];

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                arrayOfStrings[i] = new string((char)rand.Next(65, 91), rand.Next(1, 50));
            }

            return arrayOfStrings;
        }
    }
}
