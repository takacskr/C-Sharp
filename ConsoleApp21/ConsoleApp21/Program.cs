using System;

namespace TestApp
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
    class Program
    {
        static void Main(string[] args)
        {
            Init i = new();
            i.TestInit(out Test t);
            Console.WriteLine(t.s); // Hello!
            Console.ReadKey();
        }
    }
}