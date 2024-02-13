using System;
using System.Collections.Generic;

namespace List5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> list = new SortedList<string, int>();

            list.Add("egy", 1);
            list.Add("kettő", 2);
            list.Add("három", 3);

            foreach (KeyValuePair<string, int> item in list)
            {
                Console.WriteLine("Kulcs == {0}, Érték == {1}", item.Key, item.Value);
            }
        }
    }
}
