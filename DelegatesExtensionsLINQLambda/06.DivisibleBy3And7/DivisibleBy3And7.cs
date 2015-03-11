namespace _06.DivisibleBy3And7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DivisibleBy3And7
    {
        static void Main()
        {
            int[] arrayOfIntegers = new int[]
            {
                28,312,5,65,63,435,67,44,5462,34,36,78,6324,45687,21,
                8400,4,5,3,654,35,54,23,123,3,4366,7,210,12,21,70,78,
                564,840,5,454
            };

            //Lambda
            var divisibleLambda = arrayOfIntegers
                .Where(x => x % 21 == 0);

            Print(divisibleLambda);
            Console.WriteLine();

            //Linq
            var divisibleLinq =
                from n in arrayOfIntegers
                where n % 3 == 0 && n % 7 == 0
                select n;
            Print(divisibleLinq);
            Console.WriteLine();
        }

        static void Print(IEnumerable<int> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
        }
    }
}
