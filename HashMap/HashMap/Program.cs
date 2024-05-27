using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a HashMap
        var hashMap = new Dictionary<string, int>();

        // Adding elements to the HashMap
        hashMap.Add("apple", 5);
        hashMap.Add("banana", 3);
        hashMap.Add("orange", 8);

        // Accessing elements in the HashMap
        Console.WriteLine($"Number of apples: {hashMap["apple"]}");
        Console.WriteLine($"Number of bananas: {hashMap["banana"]}");
        Console.WriteLine($"Number of oranges: {hashMap["orange"]}");

        // Checking if a key exists in the HashMap
        if (hashMap.ContainsKey("grape"))
        {
            Console.WriteLine("Grape exists in the HashMap.");
        }
        else
        {
            Console.WriteLine("Grape does not exist in the HashMap.");
        }

        // Updating an element in the HashMap
        hashMap["banana"] = 6;
        Console.WriteLine($"Updated number of bananas: {hashMap["banana"]}");

        // Removing an element from the HashMap
        hashMap.Remove("orange");
        Console.WriteLine("Removed orange from the HashMap.");

        // Iterating through the HashMap
        Console.WriteLine("Contents of the HashMap:");
        foreach (var pair in hashMap)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}

/*  Output:
    Number of apples: 5
    Number of bananas: 3
    Number of oranges: 8
    Grape does not exist in the HashMap.
    Updated number of bananas: 6
    Removed orange from the HashMap.
    Contents of the HashMap:
    apple: 5
    banana: 6
 */