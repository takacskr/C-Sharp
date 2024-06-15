using System;
using System.Collections;

namespace TestApp
{
    class Program
    {
        public static IEnumerable EnumerableMethod(int max)
        {
            for (int i = 0; i < max; ++i)
            {
                yield return i;
            }
        }
        static void Main(string[] args)
        {
            foreach (int i in EnumerableMethod(10))
            {
                Console.Write(i);
            }
            //Console.ReadKey();
        }
    }
}