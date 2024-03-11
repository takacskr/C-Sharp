using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Concurrent;
using System.Threading;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Enumerable.Range(1, 1000000).ToArray<int>();

            Stopwatch sw = new Stopwatch();
            long sum = 0;

            sw.Start();

            for (int i = 0; i < array.Length; ++i)
            {
                sum += array[i];
            }

            sw.Stop();

            Console.WriteLine("Az eredmény: {0}", sum);
            Console.WriteLine("A ciklus által felhasznált idő: {0} ms",
            sw.ElapsedMilliseconds);

            sum = 0
                ;
            sw.Reset();
            sw.Start();

            Parallel.For(0,
            array.Length,
            () => 0,
            (long i, ParallelLoopState loop, long total) =>
            {
                total += array[i]; return total;
            },
            (x) => Interlocked.Add(ref sum, x));

            sw.Stop();

            Console.WriteLine("Az eredmény: {0}", sum);
            Console.WriteLine("A ciklus által felhasznált idő: {0} ms",
            sw.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}