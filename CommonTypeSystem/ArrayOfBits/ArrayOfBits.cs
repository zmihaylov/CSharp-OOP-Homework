namespace ArrayOfBits
{
    using System;
    public class ArrayOfBits
    {
        public static void Main()
        {
            BitArray64 myArr = new BitArray64(29015804678465);
            BitArray64 secArr = new BitArray64(654686519984651618);
            BitArray64 sameRef = myArr;
            BitArray64 sameVal = new BitArray64(29015804678465);

            Console.WriteLine(myArr[57]);

            foreach (var item in myArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine(myArr.Equals(secArr));
            Console.WriteLine(myArr.Equals(sameVal));
            Console.WriteLine(myArr.Equals(secArr));
            Console.WriteLine();
            Console.WriteLine(myArr == sameRef);
            Console.WriteLine(myArr == sameVal);
            Console.WriteLine(myArr == secArr);
            Console.WriteLine(sameRef == sameVal);
            Console.WriteLine();
            Console.WriteLine(myArr != sameRef); // False
            Console.WriteLine(myArr != sameVal); // False
            Console.WriteLine(myArr != secArr); // True
            Console.WriteLine(sameRef != sameVal); // False
        }
    }
}
