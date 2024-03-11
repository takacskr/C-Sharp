using System;
using System.Threading;

class Program
{
 /*
 * Main Szál-ID: 1
 * BlaBla...
 * Metódus Szál-ID: 5
 * Eredmény: 144
 */
    // Egy delegált típust definiálunk, amely egy olyan metódust mutat, amely egy int paramétert vár és int értéket ad vissza.
    public delegate int MyDelegate(int x);

    // Ez a metódus egy egész szám négyzetét számolja ki, majd visszaadja az eredményt.
    static int Square(int x)
    {
        // Kiírjuk a konzolra a jelenlegi szál azonosítóját.
        Console.WriteLine("Metódus Szál-ID: {0}", Thread.CurrentThread.ManagedThreadId);
        // Visszaadjuk a bemenő paraméter négyzetét.
        return (x * x);
    }

    static void Main(string[] args)
    {
        // Létrehozunk egy példányt a MyDelegate delegáltból, és hozzárendeljük a Square metódust.
        MyDelegate d = Square;
        // Kiírjuk a konzolra a jelenlegi szál azonosítóját.
        Console.WriteLine("Main Szál-ID: {0}", Thread.CurrentThread.ManagedThreadId);

        // Aszinkron művelet indítása a ThreadPool segítségével
        ThreadPool.QueueUserWorkItem(new WaitCallback(delegate (object state)
        {
            // A delegált metódust meghívjuk a bemeneti paraméterrel.
            int result = d.Invoke(12);
            // Kiírjuk a konzolra az eredményt.
            Console.WriteLine("Eredmény: " + result);
        }));

        // Kiírunk egy üzenetet a konzolra.
        Console.WriteLine("BlaBla...");
<<<<<<< HEAD

        Console.ReadKey();
=======
>>>>>>> 03df0447dbee9b3417532354bd5c1bb1552b5164
    }
}
