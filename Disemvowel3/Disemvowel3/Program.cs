using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PerformanceComparison
{
    public static class StrMod2
    {
        private static readonly HashSet<char> Disemvowels = new HashSet<char>("aeiouAEIOU");

        public static string Disemvowel(this string str)
        {
            return string.Concat(str.Where(c => !Disemvowels.Contains(c)));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrMod2.Disemvowel("Hello World!"));
        }
    }
}