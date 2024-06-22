using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(i);
        }
        int firstEvenNumber = list.Find((x) => (x % 2 == 0));
        Console.WriteLine($"The first even number: {firstEvenNumber}");

        int firstOddNumber = list.Find((x) => (x % 2 != 0));
        Console.WriteLine($"The first odd number: {firstOddNumber}");

        List<int> oddList = new List<int>();
        oddList = list.FindAll(x => x % 2 == 0);
        Console.WriteLine("All even numbers:");
        oddList.ForEach(x => Console.WriteLine(x));

        List<int> evenList = new List<int>();
        evenList = list.FindAll(x => x % 2 != 0);
        Console.WriteLine("All odd numbers:");
        evenList.ForEach(x => Console.WriteLine(x));
    }
}