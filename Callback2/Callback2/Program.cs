using System;
using System.Threading;

class Program
{
    /// <summary>
    /// X: (int, int) inputs
    /// </summary>
    static void FirstCallback(object x)
    {
        // Tuple átalakítása ValueTuple-ra
        (int, int) inputs = (ValueTuple<int, int>)x;
        Console.WriteLine("Első callback meghívva: " + inputs.Item1 + ", asd: " + inputs.Item2);
    }

    /// <summary>
    /// A második callback függvény, amely egy objektumot vár paraméterként
    /// </summary>
    static void SecondCallback(object x)
    {
        Console.WriteLine("Második callback meghívva: " + x);
    }

    /// <summary>
    /// Valamilyen lassú műveletet szimulál, majd meghívja a megadott callback függvényt
    /// </summary>
    static void DoSomethingSlow(object x, Action<object> callback)
    {
        // Késleltetés 1000 milliszekundum (1 másodperc)
        Thread.Sleep(1000);

        // web request / file read / event detection < here
        // all done, callback
        callback(x);
    }
    
    static void Main()
    {
        DoSomethingSlow((15, 25), FirstCallback);
        DoSomethingSlow(73, SecondCallback);
    }
}
