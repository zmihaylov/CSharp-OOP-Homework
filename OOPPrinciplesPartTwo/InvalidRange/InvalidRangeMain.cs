namespace InvalidRange
{
    using System;
    public class InvalidRangeMain
    {
        static void Main()
        {
            InvalidRangeException<int> ex = new InvalidRangeException<int>();
            Console.WriteLine(ex.Message);
            InvalidRangeException<DateTime> exDT = new InvalidRangeException<DateTime>();
            Console.WriteLine(exDT.Message);
        }
    }
}
