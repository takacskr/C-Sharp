using System;
namespace TestApp
{
    class MyClass
    {
        public int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass s = new MyClass();
            s.x = 10;

            // A p nevű referencia ugyanarra a memóriaterületre hivatkozik mint s
            MyClass p = s;
            p.x = 14;

            Console.WriteLine(s.x); // 14

            Console.ReadKey();
        }
    }
}