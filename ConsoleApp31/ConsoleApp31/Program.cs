using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp31
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            return String.Concat(str.Where(c => !("aeiouAEIOU".Contains(c))));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Disemvowel("This website is for losers LOL!"));


        }
    }
}
