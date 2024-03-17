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

            //var result = from number in list select number; // Query Expression Format
            //var result = list.Select(number => number); // LINQ To Objects

            /*
            var result = from number in list
                         where number % 2 == 0
                         select number;
            */

            //var result = list.Where(number => number % 2 == 0);

            Func<int, bool> predicate = x => x % 2 == 0;
            IEnumerable<int> result = list.Where(predicate);
        
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadKey();
        }
    }
}