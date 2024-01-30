using System;

namespace Inheritance2
{
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual void Eat()
        {
            Console.WriteLine("Eszik...");
        }
    }


    class Dog : Animal
    {
        public Dog(string name)
            : base(name) { }

        // Shadowing a new kulcsszóval - szándékosan "takarjuk el"
        // az eredeti metódus implementációt
        public new virtual void Eat()
        {
            Console.WriteLine("Csontot eszik...");
        }
    }

    class Bulldog : Dog
    {
        public Bulldog(string name)
            : base(name) { }

    }

    class Crocodile : Animal
    {
        public Crocodile(string name)
            : base(name) { }

        public override void Eat()
        {
            Console.WriteLine("Embert eszik...");
        }
    }

    class BigEvilCrocodile : Crocodile
    {
        public BigEvilCrocodile(string name)
            : base(name) { }

        public override void Eat()
        {
            Console.WriteLine("Hajót eszik...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Állat");
            animal.Eat();

            Dog dog = new Dog("Kutya");
            dog.Eat();

            Crocodile crocodile = new Crocodile("Krokodil");
            crocodile.Eat();

            BigEvilCrocodile bigEvilCrocodile = new BigEvilCrocodile("Nagy krokodil");
            bigEvilCrocodile.Eat();

            Bulldog bulldog = new Bulldog("Bulldog");

            /* A Dog utódjai már nem látják az eredeti Eat metódust. Viszont készíthetünk belőle virtuális metódust,
            amelyet az utódai már kedvükre használhatnak. Azaz, a new módosítóval ellátott metódus új sort kezd, amikor
            a fordító felépíti a metódustáblát, vagyis a new virtual kulcsszavakkal ellátott metódus lesz az új
            metódussorozat gyökere. */
            bulldog.Eat();

            Animal[] animalArray = new Animal[2];
            animalArray[0] = new Animal("Állatkirály");
            animalArray[1] = new Dog("Sunny");

            animalArray[0].Eat();

            /* Az Eat metódus végrehajtása során a megfelelő metódusfelüldefiniálás az objektum típusa alapján történik,
            * és mivel mindkét elem Animal típusú, mindkét esetben az Animal osztály Eat metódusa hívódik meg. */
            animalArray[1].Eat();

        }
    }
}
