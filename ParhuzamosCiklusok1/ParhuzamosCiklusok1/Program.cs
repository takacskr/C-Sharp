using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Enumerable.Range(0, 10000).ToArray<int>();
            Stopwatch sw = new Stopwatch();

            long result1 = 0;
            long result2 = 0;

            sw.Start();

            Parallel.For(
            0, //honnan
            array.Length, //meddig
            (i) => Console.WriteLine(array[i])); //ciklustörzs

            sw.Stop();

            result1 = sw.ElapsedMilliseconds;

            Console.ReadKey();

            sw.Reset();
            sw.Start();

            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine(array[i]);
            }

            sw.Stop();

            result2 = sw.ElapsedMilliseconds;

            Console.WriteLine("Az első ciklus által felhasznált idő: {0} ms",
            result1);
            Console.WriteLine("A második ciklus által felhasznált idő: {0} ms",
            result2);

            Console.ReadKey();
        }
    }
}