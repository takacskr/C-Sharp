using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;

/*
    Output:
    Main task started
    Another background task started
    Main task is not blocked, iteration 0
    Main task is not blocked, iteration 1
    Main task is not blocked, iteration 2
    Another background task completed
    Main task is not blocked, iteration 3
    Main task is not blocked, iteration 4
    Main task completed
 */

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Main task started");

        DoBackgroundWorkAsync();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main task is not blocked, iteration " + i);
            await Task.Delay(1500);
        }

        Console.WriteLine("Main task completed");
        Console.ReadLine();
    }

    static async Task DoBackgroundWorkAsync()
    {
        Console.WriteLine("Another background task started");
        await Task.Delay(4000);
        Console.WriteLine("Another background task completed");
    }
}