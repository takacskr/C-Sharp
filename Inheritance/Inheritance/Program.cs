namespace Inheritance
{
    class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("Nyam nyam...");
        }
    }

    class Dog : Animal
    {
        public Dog(string name)
            : base(name) { }

        public override void Eat()
        {
            Console.WriteLine("A kutya csontot rág...");
        }
    }

    class Crocodile : Animal
    {
        public Crocodile(string name)
            : base(name) { }

        public new virtual void Eat()
        {
            Console.WriteLine("A krokodil embert rág...");
        }
    }

    class BigEvilCrocodile : Crocodile
    {
        public BigEvilCrocodile(string name)
            : base(name) { }

        public void Eat()
        {
            Console.WriteLine("A krokodil óceánjárót rág...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new("Állat");
            Dog dog = new("Füli");
            Crocodile crocodile = new("Aladár");
            BigEvilCrocodile bigEvilCrocodile = new("Godzilla");
            
            animal.Eat();
            dog.Eat();
            crocodile.Eat();
            bigEvilCrocodile.Eat();
        }
    }
}
