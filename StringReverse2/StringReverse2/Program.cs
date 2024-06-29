using System;

namespace StringReverse
{
    public static class StringExtension
    {
        public static string Reverse(this string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "World";
            Console.WriteLine(str.Reverse());
        }
    }
}
