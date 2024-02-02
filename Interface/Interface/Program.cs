namespace Interface
{
    interface IAnimal
    {
        void Eat();
    }

    abstract class AbstractAnimal : IAnimal
    {
        public abstract void Eat();
    }

    class Dog : AbstractAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Ham ham...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
        }
    }
}
