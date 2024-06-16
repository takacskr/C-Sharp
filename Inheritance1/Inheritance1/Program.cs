namespace Inheritance1
{
    internal class Program
    {
        public class Animal
        {
            public Animal(string name)
            {
                this.Name = name;
            }

            public string Name { get; set; }

            public virtual void Eat()
            {
                Console.WriteLine("Hamm hamm...");
            }
        }

        public class Dog : Animal
        {
            public Dog(string name) : base(name) { }

            public override void Eat()
            {
                Console.WriteLine("Harap harap...");
            }
        }

        public class Crocodile : Animal
        {
            public Crocodile(string name) : base(name) { }

            public override void Eat()
            {
                Console.WriteLine("Fűrészes harapás...");
            }
        }

        static void Main(string[] args)
        {
            Dog d = new Dog("Füli");
            Crocodile c = new Crocodile("Aladár");

            d.Eat();
            c.Eat();
        }
    }
}
