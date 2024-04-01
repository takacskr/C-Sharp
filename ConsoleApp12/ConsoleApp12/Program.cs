using System;

namespace ConsoleApp12
{
    class Dog
    {
        private int _age;
        
        public string Name { get; set; }

        public int Age
        {
            get { return _age * 7; }
            set { _age = value; }
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