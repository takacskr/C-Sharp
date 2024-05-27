using System;
using System.Threading;

class Program
{
    static void FirstCallback(object x)
    {
        Console.WriteLine($"Első callback meghívva: {x}");
    }

    static void SecondCallback(object x)
    {
        Console.WriteLine("Második callback meghívva: " + x);
    }

    /*
     * A DoSomethingSlow függvény definíciója pontosan azt mondja, hogy egy 'object' típusú paramétert vár,
     * valamint egy olyan függvényt (Action<object>), amely szintén egy object típusú paramétert vár,
     * és nincs visszatérési értéke. Ez a jelölés lehetővé teszi, hogy a DoSomethingSlow függvény
     * bármilyen callback függvényt fogadjon, amely megfelel ennek a leírásnak.
     */

    // Az 'Action<>' egy TÍPUST jelöl!
    // Egy olyan függvényt, mely egy object típusú paramétert vár és nincs visszatérési értéke

    //     paraméter 1. (object típus x néven), paraméter 2. (Action<típus> callback néven)
    static async Task DoSomethingSlow(object x, Action<object> callback)
    {
        // Késleltetés 1000 milliszekundum (1 másodperc)
        await Task.Delay(1000);

        // web request / file read / event detection < here
        // all done, callback
        callback(x);
    }
    static async Task Main()
    {
        await DoSomethingSlow((42, 92, "text"), FirstCallback);
        await DoSomethingSlow(73, SecondCallback);
    }
}
