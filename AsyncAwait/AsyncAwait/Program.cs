using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static async void DoOperations()
        {
            var result = await Task<string>.Factory.StartNew(
            () => ReallyLongOperation()
            );

            Console.WriteLine("Az eredmény: {0}", result);
        }
        static string ReallyLongOperation()
        {
            Thread.Sleep(2000);
            return "Siker";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("A művelet előtt...");

            DoOperations();
            Console.WriteLine("A művelet után...");

            Console.ReadKey();
        }
    }
}