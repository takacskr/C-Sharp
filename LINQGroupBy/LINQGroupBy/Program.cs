using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LinqOrderby
{
    class Program
    {
        static void Main()
        {
            List<string> names = new List<string>()
            {
                "Szandra", null, "István", "Iván", "Jolán", "Jenő", "Béla",
                "Balázs", "Viktória", "Vazul", "Töhötöm", "Tamás", null
            };

            var result1 = names.GroupBy(name =>
            {
                return name == null ? '0' : name[0];

            }).OrderBy(group => group.Key);

            var result2 = from name in names
                          group name by
                          name == null ? '0' : name[0]
                          into namegroup
                          orderby namegroup.Key
                          select namegroup;

            foreach (var group in result2)
            {
                Console.WriteLine(group.Key);

                foreach (string name in group)
                {
                    Console.WriteLine("-- {0}", name == null ? "null" : name);
                }
            }

            Console.ReadKey();
        }
    }
}
