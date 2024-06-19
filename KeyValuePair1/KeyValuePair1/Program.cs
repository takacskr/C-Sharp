using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        SortedList<string, int> sList = new SortedList<string, int>();
        sList.Add("apple", 1);
        sList.Add("banana", 2);
        sList.Add("lemon", 3);

        foreach (KeyValuePair<string, int> item in sList)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
}