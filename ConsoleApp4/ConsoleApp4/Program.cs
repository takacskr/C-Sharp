using System;

namespace ConsoleApp4
{
    class Person
    {
        public Person() { }

        private string name = "";
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
            list.Add(new Person() { Name = "Géza" });

            list.Insert(2, new Person() { Name = "Gergely" });

            foreach (Person p in list)
            {
                Console.WriteLine(p.Name);
            }
        }

    }
}
