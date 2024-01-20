namespace ConsoleApp11
{
    class Dog
    {
        string _name;
        int _age;

        public static int numberOfDogs = 0;

        public Dog(string name, int age)
        {
            _name = name;
            _age = age;

            numberOfDogs++;
        }

        public void Bark()
        {
            Console.WriteLine("Wuf");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog jack = new Dog("jack", 1);
            Dog rocky = new Dog("rocky", 1);
            Dog buddy = new Dog("buddy", 1);

            Console.WriteLine(Dog.numberOfDogs);
            Console.ReadLine();
        }
    }
}
