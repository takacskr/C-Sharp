using System;

// A névtér deklarációja, melyben a program osztálya található
namespace TestApp
{
    // A program fő osztálya
    class Program
    {
        // Delegate definíciója, melynek nincs bemenő paramétere, és nincs visszatérési értéke sem
        public delegate void Test();

        // A program belépési pontja
        static void Main(string[] args)
        {
            // Lokális változó deklarálása és inicializálása
            int x = 10;

            // A `Test` típusú delegált inicializálása egy névtelen metódussal
            Test t = delegate ()
            {   // Egy névtelen metódus eléri az őt tároló blokk lokális változóit, és módosíthatja is őket
                // Lokális változó módosítása a névtelen metódusban
                x = 11;

                // Az új x érték kiírása a konzolra
                Console.WriteLine(x); // 11-et ír ki a konzolra
            };

            // A névtelen metódus meghívása
            t();

            // Várakozás egy billentyű lenyomására, mielőtt a program befejeződne
            Console.ReadKey();
        }
    }
}
