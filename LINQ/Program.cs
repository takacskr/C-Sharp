using System;
using System.Linq;
using System.Collections.Generic;

/*
 * LINQ in C# provides several standard query operators that you can use to perform various operations on collections.
 * Here are some of the most commonly used LINQ operators:
 * 
Filtering Operators:
- Where: Filters a sequence of values based on a predicate.
- OfType: Filters the elements of an IEnumerable based on a specified type.

Projection Operators:
- Select: Projects each element of a sequence into a new form.
- SelectMany: Projects each element of a sequence to an IEnumerable<T> and flattens the resulting sequences into one sequence.

Ordering Operators:
- OrderBy: Sorts the elements of a sequence in ascending order.
- OrderByDescending: Sorts the elements of a sequence in descending order.
- ThenBy: Performs a subsequent ordering of the elements in a sequence in ascending order.
- ThenByDescending: Performs a subsequent ordering of the elements in a sequence in descending order.

Join Operators:
- Join: Correlates the elements of two sequences based on matching keys.
- GroupJoin: Correlates the elements of two sequences based on matching keys and groups the results.

Grouping Operators:
- GroupBy: Groups the elements of a sequence based on a key selector function.

Set Operators:
- Distinct: Returns distinct elements from a sequence.
- Union: Produces the set union of two sequences.
- Intersect: Produces the set intersection of two sequences.
- Except: Produces the set difference of two sequences.

Element Operators:
- First: Returns the first element of a sequence.
- FirstOrDefault: Returns the first element of a sequence, or a default value if the sequence contains no elements.
- Single: Returns the only element of a sequence, or throws an exception if there is not exactly one element in the sequence.
- SingleOrDefault: Returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.

Aggregation Operators:
- Count: Returns the number of elements in a sequence.
- Sum: Computes the sum of the sequence of numeric values.
- Min: Returns the minimum value in a sequence.
- Max: Returns the maximum value in a sequence.
- Average: Computes the average of a sequence of numeric values.
- Aggregate: Applies an accumulator function over a sequence.

 */

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>()
            {
                "alma", "körte", "szilva", "barack", "szőlő", "görögdinnye", "banán",
                "narancs", "füge", "avokádó", "sárgadinnye"
            };

            IOrderedEnumerable<string> result = from fruit in fruits
                                                orderby fruit[0], fruit[1]
                                                select fruit;

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            IEnumerable<int> squaredEvenNumbers = numbers
                                        .Where(number => number % 2 == 0)
                                        .Select(number => number * number);

            foreach (int number in squaredEvenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
