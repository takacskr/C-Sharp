﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQNevRendezes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Szandra", "István", "Iván", "Jolán", "Jenő", "Béla",
                "Balázs", "Viktória", "Vazul", "Töhötöm", "Tamás"
            };

            IOrderedEnumerable<string> result1 = names.OrderBy(name => name[0])
                                                       .ThenBy(name => name[1]);
            IOrderedEnumerable<string> result2 = from name in names
                                                 orderby name[0], name[1]
                                                 select name;

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}