using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Szál-Id: {0}", Thread.CurrentThread.ManagedThreadId);
        Console.ReadKey();
    }
}