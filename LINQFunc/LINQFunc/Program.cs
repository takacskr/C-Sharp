using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQFunc
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>()
            {
                12, 4, 56, 72, 34, 0, 89, 22
            };

            Func<int, bool> predicate = (x) =>
            {
                Console.WriteLine("Szűrés...");
                return x > 30;
            };

            Console.WriteLine("Lekérdezés előtt...");

            IEnumerable<int> result = from number in list
                         where predicate(number)
                         select number;

            Console.WriteLine("Lekérdezés után...");

            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}