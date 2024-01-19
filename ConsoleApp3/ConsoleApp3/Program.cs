using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foglalt memória: {0}",
            GC.GetTotalMemory(false));
            for (int i = 0; i < 10; ++i)
            {
                int[] x = new int[1000];
            }
            Console.WriteLine("Foglalt memória: {0}",
            GC.GetTotalMemory(false));
            GC.Collect(); // meghívjuk a szemétgyűjtőt
            Console.WriteLine("Foglalt memória: {0}",
            GC.GetTotalMemory(false));
            Console.ReadKey();
        }
    }
}
