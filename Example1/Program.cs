using System;
using static System.Console;
using System.Collections.Generic;

namespace Example1
{
    internal class Program
    {
        // Main method, the entry point of the program
        static void Main(string[] args)
        {
            // Create a predicate (a function that returns a boolean value) that checks if a number is greater than 5
            Predicate<int> GreaterThanFive = x => x > 5;

            // Define an array of integers
            int[] array = { 3, 9, 5, 13, 12, 30 };

            // Use the predicate to filter the array and get a new array with only the numbers greater than 5
            int[] query = Filter(array, GreaterThanFive);

            // Iterate over the filtered array and print each value to the console
            foreach (int value in query)
            {
                WriteLine(value);
            }
        }

        // A simple function that checks if a number is greater than 5
        static bool GreaterThanFive(int x)
        {
            return x > 5;
        }

        // A function that filters an array using a predicate
        static int[] Filter(int[] src, Predicate<int> p)
        {
            // Create a new list to store the filtered values
            List<int> dst = new List<int>();

            // Iterate over the source array
            foreach (int value in src)
            {
                // Check if the predicate returns true for the current value
                if (p(value))
                {
                    // If the predicate returns true, add the value to the destination list
                    dst.Add(value);
                }
            }

            // Convert the list to an array and return it
            return dst.ToArray();
        }
    }
}