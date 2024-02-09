namespace ConsoleApp35
{
    interface IAnimal
    {
        void Eat();
    }

    interface IDog : IAnimal
    {
        void Vau();
    }

    class Dog : IDog
    {
        public void Eat()
        {
            Console.WriteLine("A kutya eszik...");
        }

        public void Vau()
        {
            Console.WriteLine("Vau vau...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            IAnimal ia = dog as IAnimal;

            if (ia != null)
            {
                Console.WriteLine("Az objektum megvalósítja az IAnimal-t");
            }

            if (dog is IDog)
            {
                Console.WriteLine("Az objektum megvalósítja az IDog-ot");
            }
        }
    }
}
