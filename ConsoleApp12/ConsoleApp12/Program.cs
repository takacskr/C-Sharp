using System;

namespace ConsoleApp12
{
    class Dog
    {
        public string Name { get; set; }

        private int age;

        public int Age
        {
            get { return age * 7; }
            set { age = value; }
        }

        public Dog(string name = "", int age = 0)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Füli", 2);
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Age);
        }
    }
}