using System.Diagnostics;

namespace ConsoleApp30
{
    static class A1
    {
        static public int x = 10;
    }
    static class A2
    {
        static public int x;
        static A2()
        {
            x = 10;
        }
    }
internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < 100000000; ++i)
            {
                int x = A1.x;
            }

            Console.WriteLine("Eltelt idõ (A1): {0}ms", sw.ElapsedMilliseconds);
            
            sw = Stopwatch.StartNew();
            
            for (int i = 0; i < 100000000; ++i)
            {
                int x = A2.x;
            }
            
            Console.WriteLine("Eltelt idõ (A2): {0}ms", sw.ElapsedMilliseconds);
            
            Console.ReadKey();
        }
    }
}
