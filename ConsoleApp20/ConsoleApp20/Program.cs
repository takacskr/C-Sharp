using System;

namespace Swap
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

            Console.WriteLine($"Csere előtt: x = {x}, y = {y}");

            Test t = new Test();

            // Egy ref paraméterrel ellátott változó átadásakor a memóriacímét adja át, nem pedig az értékét.
            // Ez lehetővé teszi, hogy a metódus közvetlenül módosítsa az eredeti változót,
            // és ez a változás visszahat az eredeti kódban is.
            t.Swap(ref x, ref y);

            Console.WriteLine($"Csere után: x = {x}, y = {y}");

            Console.ReadKey();
        }
    }
}