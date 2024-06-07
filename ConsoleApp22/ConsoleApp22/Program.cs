namespace ConsoleApp22
{
    internal class Program
    {
        class Init
        {
            public void TestInit(out Test t)
            {
                t = new Test()
                {
                    s = "Hello"!
                };
            }
        }

        class Test
        {
            public string? s = null;
        }

        static void Main(string[] args)
        {
            Init i = new ();
            Test t = new Test();
            i.TestInit(out t);
            Console.WriteLine(t.s); // Hello
        }
    }
}
