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

            IEnumerable<int> result0 = list.Where((number, index) => index % 2 == 0);

            IEnumerable<int> result1 = from number in list
                          where number > 30
                          select number;

            // A lekérdezés a páros indexű elemeket választja ki

            IEnumerable<int> result2 = (from number in list select number)
                .Where(number => number > 30);

            IEnumerable<int> result3 = list.Where(number => number > 30);

            // Rendezés növekvő sorrendbe
            IEnumerable<int> result4 = list.OrderBy(number => number);

            // Rendezés növekvő sorrendbe
            IEnumerable<int> result5 = from number in list
                                       orderby number ascending
                                       select number;

            // Rendezés csökkenő sorrendbe
            IEnumerable<int> result6 = from number in list
                                       orderby number descending
                                       select number;

            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}