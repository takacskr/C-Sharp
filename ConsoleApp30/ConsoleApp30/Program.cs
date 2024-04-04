using System;
using System.Diagnostics;

// Ez a C# program bemutatja a különbséget a statikus konstruktor
// és a statikus adattag között a program futási idejében.

namespace ConsoleApp30
{
    // A1 osztály: Ez egy statikus osztály, amely egy publikus statikus adattaggal, x-szel rendelkezik.
    //Ez az adattag inicializált, és az inicializáló kifejezésben értékadást kap(10).
    //Mivel ez egy statikus adattag, az értéke az osztály betöltésekor kerül inicializálásra.
    static class A1
    {
        public static int x = 10;
    }

    // A2.x adattag inicializálása a static A2() konstruktorban történik. Ez azt jelenti,
    // hogy az A2.x értékének inicializálása akkor történik, amikor először hivatkoznak az A2 osztályra.
    // Ez a módszer lassabb lehet a futási idő szempontjából, mivel az értékadás csak akkor történik meg,
    // amikor először használják az A2 osztályt. 
    static class A2
    {
        public static int x;
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
