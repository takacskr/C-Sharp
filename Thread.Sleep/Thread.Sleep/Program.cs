using System;
using System.Threading;

namespace ThreadSleep
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Start...");
            Thread.Sleep(5000);
            Console.WriteLine("Stop...");

            Console.ReadKey();
        }
    }
}
