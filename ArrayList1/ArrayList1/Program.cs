using System;
using System.Collections;

namespace ArrayListTest
{
    class Program
    {
        static void Main()
        {
            // Create a new ArrayList
            ArrayList list = new ArrayList();

            // Add new elements to the ArrayList
            list.Add("Apple");
            list.Add(123);
            list.Add(3.14);
            list.Add(new object());

            // Access elements using indexing
            Console.WriteLine("Element at index 0:" + list[0]); // Apple

            // Remove an element
            list.Remove(123);

            // Check if an element exists
            Console.WriteLine("Contains 'Apple': " + list.Contains("Apple")); // True

            // Iterate through the ArrayList
            Console.WriteLine("Elements in the ArrayList");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}