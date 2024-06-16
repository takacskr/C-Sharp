using System;
namespace TestApp
{
    class Program
    {
        static public int Fact(int x)
        {
            if (x == 0) { return 1; }
            else return x * Fact(x - 1);
        }
        static void Main(string[] args)
        {
            int result = Fact(10);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}