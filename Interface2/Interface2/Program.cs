namespace Interface2
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
            dog.Eat();
            dog.Vau();
        }
    }
}
