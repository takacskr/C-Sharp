using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PerformanceComparison
{
    public static class StrMod1
    {
        private static readonly HashSet<char> Disemvowels = new HashSet<char>("aeiouAEIOU");

        public static string Disemvowel(string str)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in str)
            {
                if (!Disemvowels.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrMod1.Disemvowel("This website is for losers LOL!"));
        }
    }
}
