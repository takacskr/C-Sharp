using System;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>()
            {
                1, 1, 3, 5, 6, 6, 10, 11, 1
            };

            IEnumerable<int> result = list.Select(number => number).Distinct().ToList();

            foreach (int item in result)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadKey();
        }
    }
}