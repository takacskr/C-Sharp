namespace ConsoleApp8
{
    class Dog
    {
        private string _name;
        private int _age;

        string Name { get; set; }
        int Age { get; set; }

        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
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
