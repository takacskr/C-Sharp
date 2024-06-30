using System;

namespace ConsoleApp31
{
    public static class StrModify
    {
        public static string Disemvowel(this string str)
        {
            return String.Concat(str.Where(c => !("aeiouAEIOU".Contains(c))));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrModify.Disemvowel("This website is for losers LOL!"));
        }
    }
}
