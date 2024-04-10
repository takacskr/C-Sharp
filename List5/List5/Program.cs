using System;
using System.Collections.Generic;

namespace List5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A "SortedList<T, U>" kulcs-érték párokat tárol el, és a kulcs alapján rendezi is őket
            SortedList<string, int> list = new SortedList<string, int>();

            list.Add("egy", 1);
            list.Add("kettő", 2);
            list.Add("három", 3);

            // A lista elemei a kulcs-érték párokat reprezentáló "KeyValuePair<T, U>" objektumok
            foreach (KeyValuePair<string, int> item in list)
            {
                Console.WriteLine($"Kulcs == {item.Key}, Érték == {item.Value}");
            }
        }
    }
}
