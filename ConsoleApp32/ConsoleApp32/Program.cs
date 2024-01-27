using System;
namespace TestApp
{
    struct Test
    {
        public int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = t1;
            t2.x = 10;
            Console.WriteLine("t1.x = {0}, t2.x = {1}", t1.x, t2.x);
            Console.ReadKey();
        }
    }
}