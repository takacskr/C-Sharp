using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Person
    {
        public Person() { }

        private string name;

        public string Name
        {
            get => name;
            set { name = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Person> list = new List<Person>();

            list.Add(new Person() { Name = "István" });
            list.Add(new Person() { Name = "Béla" });
            list.Add(new Person() { Name = "László" });
            list.Add(new Person() { Name = "Gergely" });
            list.Add(new Person() { Name = "Béla" });
            list.Add(new Person() { Name = "Gergely" });
            list.Add(new Person() { Name = "Géza" });

            // We want to find how many elements are duplicated in the list
            var duplicatedCount = list
               .GroupBy(p => p.Name)
               .Where(g => g.Count() > 1)
               .Sum(g => g.Count() - 1);

            Console.WriteLine("Number of duplicated elements: " + duplicatedCount);

            foreach (Person p in list)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}