using System;
using System.Threading.Tasks;

/*
    Async elott
    2024. 05. 07. 16:47:49
    2024. 05. 07. 16:47:51
    Async után

    await nélkül:
    (a második dátumot már nem várja meg a program, kilép)
    Async elott
    2024. 05. 07. 17:00:30
    Async után


 */

namespace PeldaAsyncawait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Async előtt");
            await DoThingsAsync();
            Console.WriteLine("Async után");
        }

        private static async Task PrintCurrentTimeAsync()
        {
            try
            {
                Console.WriteLine(DateTime.Now);
                await Task.Delay(2000);
                Console.WriteLine(DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static async Task DoThingsAsync()
        {
            await PrintCurrentTimeAsync();
        }
    }
}