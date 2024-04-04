using System;

namespace ConsoleApp24
{
    class Person
    {
        // Ha egy paraméternek értéket adunk a konstruktorban,
        // akkor nem szükséges utólag megadni ezt argumentumként,
        // tehát nem jelez hibát a fordító

        public Person(string firstName, string lastName, string job = "N/A")
        {
            FirstName = firstName;
            LastName = lastName;
            Job = job;
        }
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Job { get; private set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new(lastName: "Kiss", firstName: "János");
            Person p2 = new(job: "hókotró", firstName: "István", lastName: "Nagy");

            Console.WriteLine($"{p1.LastName} {p1.FirstName}, {p1.Job}");
            Console.WriteLine($"{p2.LastName} {p2.FirstName}, {p2.Job}");
        }
    }
}
