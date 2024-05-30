using System;
using System.Collections.Generic;

namespace GenericExample
{
    public class Container<T>
    {
        private List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Remove(T item)
        {
            list.Remove(item);
        }

        public void Display()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Container<int> intContainer = new Container<int>();
            intContainer.Add(10);
            intContainer.Add(20);
            intContainer.Add(30);
            Console.WriteLine("Int Container:");
            intContainer.Display();

            Container<string> stringContainer = new Container<string>();
            stringContainer.Add("Hello");
            stringContainer.Add("World");
            stringContainer.Add("Generics");
            Console.WriteLine("String Container:");
            stringContainer.Display();

            Container<Person> personContainer = new Container<Person>();
            personContainer.Add(new Person("John", 25));
            personContainer.Add(new Person("Jane", 30));
            personContainer.Add(new Person("Bob", 35));
            Console.WriteLine("Person Container:");
            personContainer.Display();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} is {Age} years old.";
        }
    }
}