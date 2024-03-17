using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQWhere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                12, 4, 56, 72, 34, 0, 89, 22
            };

            IEnumerable<int> result1 = from number in list
                          where number > 30
                          select number;

            IEnumerable<int> result2 = list.Where(number => number > 30);

            IEnumerable<int> result3 = (from number in list select number)
                .Where(number => number > 30);

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}