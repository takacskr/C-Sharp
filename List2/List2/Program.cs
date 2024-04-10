using System;
using System.Collections.Generic;

namespace List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1000));
                Console.WriteLine(list[i]);
            }

            Console.WriteLine();
            list.Sort();

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}