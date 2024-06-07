using System;

namespace ConsoleApp26
{
    class Person
    {
        private string? _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


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
            Person person = new Person(name: "Pityu", age: 28);

            person.DisplayData();
        }
    }
}
