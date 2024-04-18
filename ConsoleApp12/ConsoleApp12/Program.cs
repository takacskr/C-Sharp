using System;

namespace ConsoleApp12
{
    class Dog
    {
        private int _age;

        //  private set:
        //  Az osztályon kívülről nem lehet közvetlenül beállítani az Name tulajdonságot.
        //  Az érték csak az osztályon belül módosítható.
        public string Name { get; private set; }

        public int Age
        {
            get { return _age * 7; }
            set { _age = value; }
        }

        // Mivel kezdőértéket adtam meg a paramétereknek, így bármelyik kihagyható,
        // a fordító nem fog hibát jelezni
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
            Dog dog2 = new Dog("Morzsi");

            Console.WriteLine($"A kutya neve: {dog.Name}, A kutya kora: {dog.Age}");
            Console.WriteLine($"A kutya neve: {dog2.Name}, A kutya kora: {dog2.Age}");
        }
    }
}