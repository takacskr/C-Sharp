using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Thread t = new Thread(delegate () { Thread.Sleep(2000); });
        t.Start();
        t.Join();
        Console.WriteLine("Vége");
        Console.ReadKey();
    }
}