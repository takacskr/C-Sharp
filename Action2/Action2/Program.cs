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
        await Program.DoSomethingSlow((42, 92, "text"), FirstCallback);
        await Program.DoSomethingSlow(73, SecondCallback);
    }
}
