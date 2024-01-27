namespace Struct
{
    // Minden struktúra alapértelmezetten rendelkezik egy
    // konstruktorszerűséggel(nem igazi konstruktor),
    // amely elvégzi a tagok nullára inicializálását
    struct Test
    {
        public int x;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ha nem használjuk a new operátort,
            // akkor kötelezően definiálni kell az értéket
            Test test = new Test();
            Console.WriteLine(test.x); // x == 0

            Console.ReadKey();
        }
    }
}
