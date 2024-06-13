using System;

namespace TestApp
{
    class Test
    {
        public void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Test t = new Test();
            t.Swap(ref x, ref y);
            Console.WriteLine("x = {0}, y = {1}", x, y);
            Console.ReadKey();
        }
    }
}