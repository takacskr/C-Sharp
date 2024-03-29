﻿using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static int Square(int x)
    {
        // 2.1 Kiírjuk, hogy a Square metódus futása elindult
        Console.WriteLine("Square metódus elindult a háttérszálon...");

        // Várunk 100 milliszekundumot a szimulált művelet miatt
        Thread.Sleep(100);

        // 4. Kiírjuk, hogy a Square metódus befejeződött
        Console.WriteLine("Square metódus befejeződött.");

        // 4.1 Visszatérünk a szám négyzetével
        return x * x;
    }

    static async Task Main()
    {
        // 1. Kiírjuk, hogy a Main metódus elindult
        Console.WriteLine("Main metódus elindult a szálban...");

<<<<<<< HEAD
        // Aszinkron módon elindítjuk a Square metódust egy háttérszálon
=======
        // 2. Aszinkron módon elindítjuk a Square metódust egy háttérszálon
>>>>>>> 03df0447dbee9b3417532354bd5c1bb1552b5164
        Task<int> squareTask = Task.Run( () => Square(12) );

        // Várunk egy kicsit, hogy a háttérszál elinduljon és befejeződjön
        await Task.Delay(50);

        // 3. A háttérszál elindult és fut, de a Main metódus szála szabadon marad
        Console.WriteLine("Main metódus szála tovább fut, míg a háttérszál fut...");

        // Várakozunk a háttérszál befejeződésére és az eredményre
        int result = await squareTask;

        // 5. Kiírjuk az eredményt
        Console.WriteLine($"A négyzet: {result}");

        // 6. Kiírjuk, hogy a Main metódus befejeződött
        Console.WriteLine("Main metódus befejeződött.");
    }
}