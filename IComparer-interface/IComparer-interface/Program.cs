using System;
using System.Collections;
using System.Collections.Generic; // A List<T> osztály használatához

namespace Compare
{
    // ComparableClass osztály, amely implementálja az IComparable interfészt
    class ComparableClass : IComparable
    {
        // Az osztály adattagja, amely tárolja az összehasonlítandó értéket
        public int Value { get; private set; }

        // Konstruktor, beállítja az értéket az objektum létrehozásakor
        public ComparableClass(int value)
        {
            this.Value = value;
        }

        // Az IComparable interfész CompareTo metódusának implementációja
        public int CompareTo(object o)
        {
            if (o is ComparableClass)
            {
                ComparableClass c = (ComparableClass)o;
                // A Value tulajdonság összehasonlítása a másik ComparableClass objektum Value tulajdonságával
                return Value.CompareTo(c.Value);
            }
            else
            {
                // Ha az objektum nem ComparableClass típusú, kivételt dobunk
                throw new Exception("Nem megfelelő objektum...");
            }
        }
    }

    // ComparableClassComparer osztály, amely implementálja az IComparer<T> interfészt
    class ComparableClassComparer : IComparer<ComparableClass>
    {
        // Az IComparer<T> interfész Compare metódusának implementációja
        public int Compare(ComparableClass x, ComparableClass y)
        {
            // Az x és y ComparableClass objektumokat összehasonlítjuk a CompareTo metódus segítségével
            return x.CompareTo(y);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista létrehozása, ami ComparableClass objektumokat tartalmaz
            List<ComparableClass> list = new List<ComparableClass>();

            // Random objektum létrehozása
            Random r = new Random();

            // 10 elemű lista feltöltése véletlenszerű értékekkel
            for (int i = 0; i < 10; ++i)
            {
                list.Add(new ComparableClass(r.Next(1000)));
            }

            // Lista elemeinek kiírása
            foreach (ComparableClass c in list)
            {
                Console.Write("{0} ", c.Value);
            }
            Console.WriteLine("\nA rendezett lista:");

            // Lista rendezése a ComparableClassComparer segítségével
            list.Sort(new ComparableClassComparer());

            // Rendezett lista elemeinek kiírása
            foreach (ComparableClass c in list)
            {
                Console.Write("{0} ", c.Value);
            }
        }
    }
}
