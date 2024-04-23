using System.Collections;

/*
 * A program lényege, hogy osztálypéldányok közötti összehasonlítást végzünk.
 * 
 * Amikor egy osztály implementálja az IComparable interfészt, akkor azt jelzi,
 * hogy példányai összehasonlíthatók más példányokkal. Ez hasznos lehet például akkor,
 * amikor rendezni szeretnénk egy kollekciót, vagy amikor összehasonlításokat szeretnénk végezni példányok között.
 * 
 * Az IComparable interfész egyetlen metódust definiál: a CompareTo-t. Ez a metódus egy másik objektumot vár paraméterként,
 * és visszaadja az aktuális objektum és a paraméterként átadott objektum relációját (pl. kisebb, egyenlő, nagyobb).
 */

namespace Compare
{
    class ComparableClass : IComparable
    {
        public ComparableClass(int value)
        {
            this.Value = value;
        }

        public int Value { get; private set; }

        public int CompareTo(object o)
        {
            if (o is ComparableClass)
            {
                ComparableClass c = (ComparableClass)o;

                return Value.CompareTo(c.Value);
            }

            else
            {
                throw new Exception("Nem megfelelő objektum...");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ComparableClass> list = new List<ComparableClass>();
            
            Random r = new Random();

            for (int i = 0; i < 10; ++i)
            {
                list.Add(new ComparableClass(r.Next(1000)));
            }

            foreach (ComparableClass c in list)
            {
                Console.Write("{0} ", c.Value);
            }

            Console.WriteLine("\nA rendezett lista:");
            
            list.Sort();
            
            foreach (ComparableClass c in list)
            {
                Console.Write("{0} ", c.Value);
            }
        }
    }
}
