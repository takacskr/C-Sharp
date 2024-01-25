namespace ConsoleApp29
{
    class Test
    {
        static public int Var = Test.Init();

        static public int Init()
        {
            Console.WriteLine("Var = 10");
            return 10;
        }

        static Test()
        {
            Console.WriteLine("Statikus konstruktor");
        }

        public Test()
        {
            Console.WriteLine("Konstruktor");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");
            Test t = new();

            Console.ReadKey();
        }
    }
}
