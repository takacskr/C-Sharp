using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQToLookup
{
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { Name = "Kiss Béla", Age = 62 },
                new Person { Name = "Nagy Ágoston", Age = 33 },
                new Person { Name = "Fazekas János", Age = 62 },
                new Person { Name = "Pintér Ferenc", Age = 33 }
            };

            // ageGroups: adott kulcshoz tartozó elemeket tárolja. Egy kulcshoz több érték is tartozhat.
            ILookup<int, Person> ageGroups = people.ToLookup(person => person.Age);

            foreach (IGrouping<int, Person> ageGroup in ageGroups)
            {
                Console.WriteLine($"People with age {ageGroup.Key}");

                foreach (Person person in ageGroup)
                {
                    Console.WriteLine($"Person name: {person.Name}");
                }
            }
        }
    }
}
