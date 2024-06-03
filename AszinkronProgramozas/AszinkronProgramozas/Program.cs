using System;
using System.Threading.Tasks;

namespace PeldaAsyncawaitTaskMain
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Async előtt");
            await PrintCurrentTimeAsync();
            Console.WriteLine("Async után");
            Console.ReadKey();
        }

        private static async Task PrintCurrentTimeAsync()
        {
            Console.WriteLine(DateTime.Now);
            await Task.Delay(2000);
            Console.WriteLine(DateTime.Now);
        }
    }
}

/*
    Async elott
    2024. 06. 03. 18:23:09
    2024. 06. 03. 18:23:11
    Async után
 */