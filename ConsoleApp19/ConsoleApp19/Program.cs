using System;

namespace TestApp
{
    class Test
    {
        // Az osztályban deklarált _x változó publikus, tehát látható és elérhető más osztályok számára.
        public int _x = 10;

        // A TestMethod egy példányszintű metódus, ami egy Test típusú objektummal dolgozik.
        public void TestMethod(Test t)
        {
            // EZÉRT NEM ÍRÓDIK ÁT AZ EREDETI _x VÁLTOZÓ ÉRTÉKE!
            // A t változó most egy új Test objektumra mutat.
            t = new Test();

            // Az új objektum _x értékét beállítjuk 11-re.
            t._x = 11;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Létrehozunk egy Test objektumot.
            Test t = new Test();

            // Kiírjuk az eredeti objektum _x értékét, ami 10.
            Console.WriteLine(t._x); // Kiír: 10

            // Meghívjuk a TestMethod metódust az eredeti objektummal.
            t.TestMethod(t);

            // Az eredeti objektum _x értéke továbbra is 10 marad, mert a TestMethod egy másik objektumra mutat.
            Console.WriteLine(t._x); // Kiír: 10

            Console.ReadKey();
        }
    }
}
