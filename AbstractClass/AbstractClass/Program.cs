using System;

namespace AbstractClass
{
    abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        abstract public void Eat();
    }

    class Dog : Animal
    {
        // Calling the base constructor of the Animal class to initialize the Name property
        public Dog(string name) : base(name) { }

        public override void Eat()
        {
            Console.WriteLine("Kutya eszik...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Egy tömböt hozunk létre, amely Animal típusú elemeket tárol
            Animal[] animalArray = new Animal[2];
            animalArray[0] = new Dog("Füli");
            animalArray[1] = new Dog("Blöki");

            // Hibát jelez a fodító, mert nem lehet példányosítani az absztrakt osztályt
            // Animal animal = new Animal();
        }
    }
}
