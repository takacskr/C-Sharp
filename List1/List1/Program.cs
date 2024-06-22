using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random(1000);
        List<int> list = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            list.Add(rnd.Next(1, 1000));
        }

        list.Sort();

        foreach (int item in list)
        {
            Console.WriteLine(item);
        }

        // searching an element in the list
        Console.WriteLine(list.BinarySearch(457));

        List<int> evenList = list.FindAll(x => x % 2 == 0);

        Console.WriteLine("Even numbers: ");
        foreach (int evenNumber in evenList)
        {
            Console.WriteLine(evenNumber);
        }

        List<int> oddList = list.FindAll(x => x % 2 != 0);
        Console.WriteLine("Odd numbers: ");
        oddList.ForEach(x => Console.WriteLine(x));
    }
}