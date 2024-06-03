using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task<int> Square(int x)
    {
        // 2.1 Kiírjuk, hogy a Square metódus futása elindult
        Console.WriteLine("Square metódus elindult a háttérszálon...");

        // Várunk 2000 milliszekundumot a szimulált művelet miatt
        await Task.Delay(2000);

        // 4. Kiírjuk, hogy a Square metódus befejeződött
        Console.WriteLine("Square metódus befejeződött.");

        // 4.1 Visszatérünk a szám négyzetével
        return x * x;
    }

    static async Task DoSomething()
    {
        int x = 0;
        while (true)
        {
            Console.Write($"{x}");
            x = x == 0 ? 1 : 0;
            await Task.Delay(100);
        }
    }

    static async Task Main()
    {
        // 1. Kiírjuk, hogy a Main metódus elindult
        Console.WriteLine("Main metódus elindult a szálban...");
        
        DoSomething();
        
        // 2. Aszinkron módon elindítjuk a Square metódust egy háttérszálon
        Task<int> squareTask = Task.Run( () => Square(12) );

        // 2.0 Várunk egy kicsit, hogy a háttérszál elinduljon és befejeződjön
        await Task.Delay(50);

        // 3. A háttérszál elindult és fut, de a Main metódus szála szabadon marad
        Console.WriteLine("Main metódus szála tovább fut, míg a háttérszál fut...");

        // 3.1 Várakozunk a háttérszál befejeződésére és az eredményre
        int result = await Square(12);

        // 5. Kiírjuk az eredményt
        Console.WriteLine($"A négyzet: {result}");

        // 6. Kiírjuk, hogy a Main metódus befejeződött
        Console.WriteLine("Main metódus befejeződött.");
    }
}
