using System;

namespace DisemvowelString
{
    public static class StrMod
    {
        /// <summary>
        /// Removes all vowels from a given string.
        /// </summary>
        /// <param name="str">The input string.</param>
        /// <returns>The string with all vowels removed.</returns>
        public static string Disemvowel(string str)
        {
            IEnumerable<char> disemvowels = "aeiouAEIOU";
            IEnumerable<char> result = str.Where(c => !disemvowels.Contains(c));

            return new string(result.ToArray());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StrMod.Disemvowel("Hello, World!"));
        }
    }
}
