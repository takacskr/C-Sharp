using System;
using System.Threading;

namespace ThreadsInterlock
{
    class Program
    {
        private static int _a;

        static void Main()
        {
            _a = 2;
            Console.WriteLine($" a értéke: {_a}");
            Interlocked.Increment(ref _a);
            Console.WriteLine($" a értéke: {_a}");
            Console.ReadKey();
        }
    }
}
