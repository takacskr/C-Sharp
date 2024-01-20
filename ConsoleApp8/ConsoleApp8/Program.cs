namespace ConsoleApp8
{
    class Dog
    {
        string name;
        int age;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine("A kutya eszik...");
        }

        public void Sleep()
        {
            Console.WriteLine("A kutya alszik...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Füli", 4);
            dog.Eat();
            dog.Sleep();

            Console.ReadKey();
        }
    }
}
