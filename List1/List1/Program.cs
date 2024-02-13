using System;
using System.Collections.Generic;

namespace List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
