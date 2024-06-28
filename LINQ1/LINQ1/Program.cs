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
                10, 2, 4, 55, 22, 75, 30, 11, 12, 89
            };

            Console.WriteLine($"List count: {list.Count()}");

            //var result = from number in list select number; // Query Expression Format
            //var result = list.Select(number => number); // LINQ To Objects

            /*
            var result = from number in list
                         where number % 2 == 0
                         select number;
            */

            //var result = list.Where(number => number % 2 == 0);

            //List<int> result = list.Where(x => x % 2 == 0).ToList();

            Func<int, bool> even = x =>
            {
                return x % 2 == 0;
            };

            IEnumerable<int> result = list.Where(even);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}