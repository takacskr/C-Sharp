using System;
using System.Threading;

namespace CurrentThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Szál Id: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
