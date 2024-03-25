using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
namespace Server
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>()
             {
                10, 32, 45, 2, 55, 95, 21, 1, 64, 9, 14
             };

            var result = (from number in list
                          orderby number ascending
                          where number %2 == 0
                          select number).ToList<int>();

            result.ForEach( (number) => Console.WriteLine(number) );

            Console.ReadKey();
        }
    }
}