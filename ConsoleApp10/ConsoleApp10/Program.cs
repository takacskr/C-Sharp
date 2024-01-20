using System;

namespace ConsoleApp10
{
    class Dog
    {
        private string _name;
        private int _age;

        public Dog(string name)
        {
            _name = name;
        }

        public Dog(string name, int age) : this(name)
        {
            _age = age;
        }

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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Füli");

            Console.WriteLine(dog.Name);
        }
    }
}
