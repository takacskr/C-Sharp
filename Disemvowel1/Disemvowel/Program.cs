using System;

namespace DisemvowelString
{
    public static class StrMod
    {
        public static string Disemvowel(string str)
        {
            char[] disemvowels = "aeiouAEIOU".ToCharArray();
            List<char> result = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (!disemvowels.Contains(str[i]))
                {
                    result.Add(str[i]);
                }
            }

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
