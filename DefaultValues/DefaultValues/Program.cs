using System;

namespace ConsoleApp10
{
    class Dog
    {
        private string _name;
        private int _age;

        public Dog(string name = "", int age = 0)
        {
            Name = name;
            Age = age;
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
            Dog dog2 = new Dog("Morzsi", 7);

            Console.WriteLine(dog.Name);
            Console.WriteLine($"{dog2.Name}, {dog2.Age}");
        }
    }
}
