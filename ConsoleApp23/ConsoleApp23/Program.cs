namespace ConsoleApp23
{
    class Init
    {
        public void TestInit(out Test t)
        {
            t = new Test() { s = "Hello!" };
        }
    }

    class Test
    {
        public string? s = null;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Init init = new();
            Test test;

            // A metódus meghívásával kerül bele a szöveg a test objektum s változójába
            // mert az out referenciát ad át
            init.TestInit(out test);
            Console.WriteLine(test.s);
        }
    }
}
