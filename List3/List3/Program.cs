using System;
using System.Collections.Generic;

namespace List3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "alma", "körte", "dió", "mogyoró", "pisztácia", "mandula"
            };

            list.Sort();

            // Kereshetünk az elemek között a "BinarySearch" metódussal,
            // amely a keresett objektum indexét aadja vissza
            Console.WriteLine(list.BinarySearch("körte"));

            Console.WriteLine(list[list.BinarySearch("körte")]);

            list.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(list.Contains("körte")); // True

            list.Remove("körte");

            Console.WriteLine(list.Contains("körte")); // False

            Console.WriteLine(list.Any()); // True

            list.Clear();

            Console.WriteLine(list.Any()); // False
        }
    }
}
