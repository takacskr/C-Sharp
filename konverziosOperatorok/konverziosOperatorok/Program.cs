using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("alma");
            list.Add("dió");
            list.Add(12345);

            var result1 = from item
                          in list.Cast<string>() // this does not work because of the converting issue (number to string)
                          select item;

            var result2 = from item
                          in list.OfType<string>()
                          select item;

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}