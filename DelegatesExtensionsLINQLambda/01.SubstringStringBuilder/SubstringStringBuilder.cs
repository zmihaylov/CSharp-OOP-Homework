namespace _01.SubstringStringBuilder
{
    using System;
    using System.Text;

    class SubstringStringBuilder
    {
        public static void Main()
        {
            StringBuilder input = new StringBuilder();
            input.Append("Time to test what we have done!");

            StringBuilder result = input.Substring(10);
            Console.WriteLine(result);
            result = input.Substring(10, 2);
            Console.WriteLine(result);
        }
    }

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int startIndex, int length)
        {
            if (sb.Length <= startIndex)
            {
                throw new IndexOutOfRangeException("Start index larger than the length of input string.");
            }
            if (sb.Length < startIndex + length)
            {
                throw new IndexOutOfRangeException("The length of the substring exceeds the characters of the StringBuilder after the start index.");
            }
            return new StringBuilder(sb.ToString().Substring(startIndex, length));
        }

        public static StringBuilder Substring(this StringBuilder sb, int startIndex)
        {
            if (sb.Length <= startIndex)
            {
                throw new IndexOutOfRangeException("Start index larger than the length of input string.");
            }
            return new StringBuilder(sb.ToString().Substring(startIndex));
        }
    }
}
