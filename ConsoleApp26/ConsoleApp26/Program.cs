using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ConsoleApp26
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }


        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new(name: "Pityu", age: 38);

            person.DisplayData();
        }
    }
}
