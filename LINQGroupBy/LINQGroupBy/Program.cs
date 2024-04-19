using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOrderby
{
    class Program
    {
        static void Main()
        {
            // Defining a list of strings containing names, some of which may be null.
            List<string> names = new List<string>()
            {
                "Szandra", null, "István", "Iván", "Jolán", "Jenő", "Béla",
                "Balázs", "Viktória", "Vazul", "Töhötöm", "Tamás", null
            };

            // Using LINQ to group names by their first character and order the groups by the first character.
            // Grouping by the first character of the name, if the name is null, group it as '0'.
            var result1 = names.GroupBy(name =>
            {
                return name == null ? '0' : name[0];
            }).OrderBy(group => group.Key);

            // Using LINQ query syntax to achieve the same grouping and ordering.
            var result2 = from name in names
                          group name by
                          name == null ? '0' : name[0]
                          into namegroup
                          orderby namegroup.Key
                          select namegroup;

            // Iterating over each group in the result and printing them.
            foreach (var group in result1)
            {
                // Printing the key of the group (which is the first character).
                Console.WriteLine(group.Key);

                // Iterating over each name in the group and printing it.
                foreach (string name in group)
                {
                    // If the name is null, printing "null", otherwise printing the name.
                    Console.WriteLine("-- {0}", name == null ? "null" : name);
                }
            }

            // Waiting for a key press before closing the console window.
            Console.ReadKey();
        }
    }
}
