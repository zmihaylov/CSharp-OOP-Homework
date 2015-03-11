namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IEnumerableExtensions
    {
        static void Main()
        {
            IEnumerable<int> collection = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(collection.SumOfCollection());
            Console.WriteLine(collection.Product());
            Console.WriteLine(collection.AverageOfCollection());
            Console.WriteLine(collection.MinOfCollection());
            Console.WriteLine(collection.MaxOfCollection());
        }
    }

    public static class Extensions
    {
        public static decimal SumOfCollection<T>(this IEnumerable<T> collection)
        {
            decimal sum = 0;

            foreach (var item in collection)
            {
                sum += Convert.ToDecimal(item);
            }

            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> collection)
        {
            decimal product = 1;

            foreach (var item in collection)
            {
                product *= Convert.ToDecimal(item);
            }

            return product;
        }

        public static T MinOfCollection<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.ElementAt(0);

            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T MaxOfCollection<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.ElementAt(0);

            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static decimal AverageOfCollection<T>(this IEnumerable<T> collection)
        {
            return collection.SumOfCollection<T>() / collection.Count<T>();
        }
    }
}
