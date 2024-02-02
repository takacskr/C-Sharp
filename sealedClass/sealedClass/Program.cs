namespace sealedClass
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Ham ham...");
        }
    }

    class Dog : Animal
    {
        public sealed override void Eat()
        {
            Console.WriteLine("Vau vau ham ham...");
        }
    }

    class Dobermann : Dog
    {
        // Hibát fog jelezni a fordító mert a leszármazott nem definiálhatja át a működését (sealed)
        public override void Eat()
        {
            Console.WriteLine("Vau vau Dobermann ham ham...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
