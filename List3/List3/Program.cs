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

            Console.WriteLine(list[list.BinarySearch("körte")]);
        }
    }
}
