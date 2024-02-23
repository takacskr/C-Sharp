using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>();

        for (int i = 1; i < 10; i++)
        {
            list.Add(i);
        }

        int result = list.Find( (item) => (item % 2 == 0) );

        Console.WriteLine($"Az első páros szám: {result}");

        List<int> oddList = list.FindAll( (item) => (item % 2 != 0) );

        Console.WriteLine("Az összes páratlan szám:");

        oddList.ForEach( (item) => Console.WriteLine(item));
    }
}