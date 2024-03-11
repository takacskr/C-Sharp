using System;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                10, 2, 4, 55, 22, 75, 30, 11, 12, 89
            };

            var result = from number in list select number;
        
            foreach (var item in result)
            {
                Console.WriteLine("{0}", item);
            }
            Console.ReadKey();
        }
    }
}