using System;

namespace TestApp
{
    class Test
    {
        public void Add(int x, int y, out int result)
        {
            result = x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Add(10, 11, out int result);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}