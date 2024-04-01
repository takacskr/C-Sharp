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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
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
            Dog rocky = new Dog("rocky", 3);
            Dog buddy = new Dog("buddy", 5);

            Console.WriteLine(Dog.numberOfDogs);
            Console.WriteLine($"{jack.Name}, {jack.Age}");
            Console.ReadLine();
        }
    }
}
