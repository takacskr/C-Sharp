using System;

namespace ConsoleApp4
{
    class Person
    {
        public Person() { }

        private string name = "";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
    internal class Program
    {      
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "István" };

            Console.WriteLine(person.Name);
        }

    }
}
