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
                "Balázs", "Viktória", "Vazul", "Töhötöm", "Tamás", "Ilona"
            };

            // IOrderedEnumerable<string>
            var result1 = names.OrderBy(name => name[0]).ThenBy(name => name[1]);

            // IOrderedEnumerable<string>
            var result2 = from name in names
                                        where name.Contains("án")
                                        where name.StartsWith("I")
                                        orderby name[0], name[1]
                                        select name;
            // IEnumerable<string>
            var result3 = names.GroupBy(name => name[0])
                                                .OrderBy(group => group.Key)
                                                .SelectMany(group => group.OrderBy(name => name));
            
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
