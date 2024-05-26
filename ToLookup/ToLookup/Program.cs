using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 25 },
            new Person { Name = "David", Age = 30 }
        };

        // Group people by their age using ToLookup
        // This creates a lookup (an ILookup object) from a sequence
        // The method takes a key selector function as an argument
        ILookup<int, Person> ageGroups = people.ToLookup(person => person.Age);

        // Iterate over each age group and print the names of people in that group
        foreach (var ageGroup in ageGroups)
        {
            Console.WriteLine($"People with age {ageGroup.Key}:");

            foreach (Person person in ageGroup)
            {
                Console.WriteLine($"- {person.Name}");
            }

            Console.WriteLine();
        }
    }
}