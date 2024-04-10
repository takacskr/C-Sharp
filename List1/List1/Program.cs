using System;
using System.Collections.Generic;

namespace List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 13, 72, 48, 55, 69 };

            for (int i = 0; i < 10; i++)
            {
                // Az "Add" metódus a lista végéhez adja hozzá a paraméterként
                // megadott elemet, hasonlóan az "ArrayList"-hez
                list.Add(i);
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
