using System;
using System.Collections.Generic;

/*
This implementation follows modern C# conventions, uses classes and encapsulation,
and separates concerns for better maintainability and extensibility. The use of ageneric List<T> instead of an
array allows for dynamic resizing and provides a richer set of methods for working with collections.
 
 Here's how the code works:

1.) The ArraySorter class encapsulates the bubble sort algorithm and provides
a read-only property SortedNumbers to access the sorted list of numbers.

2.) The constructor of ArraySorter takes an IEnumerable<int> as input and initializes
a private list _numbers with the provided numbers.

3.) The SortedNumbers property calls the BubbleSort method to sort the _numbers list
and returns a read-only view of the sorted list.

4.) The BubbleSort method implements the bubble sort algorithm. It uses a nested loop to iterate
through the list and swap adjacent elements if they are in the wrong order. It also includes
an optimization to break out of the loop early if the list is already sorted.

5.) The Swap method is a helper method that swaps two elements in the _numbers list.

6.) In the Main method, an unsorted array of numbers is created.

7.) An instance of ArraySorter is created, passing the unsorted array to the constructor.

8.) The SortedNumbers property is accessed to get the sorted list of numbers.

9.) The sorted numbers are printed to the console.

 */

namespace BubbleSorter
{
    public class ArraySorter
    {
        private List<int> _numbers;

        // Constructor takes an IEnumerable<int> as input and initializes the _numbers list
        public ArraySorter(IEnumerable<int> numbers)
        {
            _numbers = new List<int>(numbers);
        }

        // Read-only property that returns the sorted list of numbers
        public IReadOnlyList<int> SortedNumbers
        {
            get
            {
                BubbleSort(); // Sort the list before returning it
                return _numbers.AsReadOnly(); // Return a read-only view of the sorted list
            }
        }

        // Implements the bubble sort algorithm
        private void BubbleSort()
        {
            int n = _numbers.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (_numbers[j] > _numbers[j + 1])
                    {
                        Swap(j, j + 1); // Swap adjacent elements if in wrong order
                        swapped = true;
                    }
                }

                // Optimization: If no swaps were made, the list is already sorted
                if (!swapped)
                    return;
            }
        }

        // Helper method to swap two elements in the _numbers list
        private void Swap(int i, int j)
        {
            int temp = _numbers[i];
            _numbers[i] = _numbers[j];
            _numbers[j] = temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedNumbers = { 64, 34, 25, 12, 22, 11, 90 };

            ArraySorter sorter = new ArraySorter(unsortedNumbers); // Create an instance of ArraySorter with the unsorted array
            IReadOnlyList<int> sortedNumbers = sorter.SortedNumbers; // Get the sorted list of numbers

            Console.WriteLine("Sorted numbers:");
            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number); // Print each sorted number
            }
        }
    }
}