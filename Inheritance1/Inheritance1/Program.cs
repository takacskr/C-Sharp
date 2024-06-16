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

        public class BigEvilCrocodile : Crocodile
        {
            public BigEvilCrocodile(string name) : base (name) { }

            // A "new" kulcsszóval tájékoztatjuk a fordítót, hogy szándékosan takarjuk el
            // az "Eat()" metódus eredeti implementációját. Ezt árnyékolásnak (shadow) nevezzük

            // A "virtual" kulcsszóval jelöljük meg az új metódussorozat gyökerét. Innentől ez lesz az alap
            public new virtual void Eat()
            {
                Console.WriteLine("Krokodil óceánjárót rág...");
            }
        }

        static void Main(string[] args)
        {
            Dog d = new Dog("Füli");
            Crocodile c = new Crocodile("Aladár");
            BigEvilCrocodile bc = new BigEvilCrocodile("Big Aladár");

            d.Eat();
            c.Eat();
            bc.Eat();
        }
    }
}
