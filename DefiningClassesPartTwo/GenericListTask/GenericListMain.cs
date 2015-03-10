namespace GenericListTask
{
    using System;

    public class GenericListMain
    {
        static void Main()
        {
            GenericList<int> testOne = new GenericList<int>(3);
            GenericList<string> testTwo = new GenericList<string>(3);
            GenericList<double> testThree = new GenericList<double>(5);

            testOne.Add(23);
            testOne.Add(13);
            testOne.Add(33);

            Console.WriteLine(testOne[0]);
            Console.WriteLine(testOne[1] + " " + testOne[2]);

            testOne.Clear();
            testOne.Add(53);
            testOne.Add(23);
            Console.WriteLine(testOne[1]);
            //Console.WriteLine(testOne[2]); //Exception here!!!

            testOne.Add(32);
            testOne.Add(22);
            testOne.Add(2);
            testOne.Add(42);
            testOne.Add(52);
            Console.WriteLine(testOne[4]);
            testOne.RemoveAt(4);
            Console.WriteLine(testOne[4]);

            testOne.Add(88);
            testOne.Add(68);
            testOne.Add(58);
            testOne.Add(48);

            Console.WriteLine(testOne[8]);
            testOne.InsertAt(33, 8);
            Console.WriteLine(testOne[8]);
            Console.WriteLine(testOne.Find(88));
            Console.WriteLine(testOne);

        }
    }
}
