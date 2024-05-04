using System;
using System.Threading.Tasks;

/*
    Main task started
    Background task started
    Main task is not blocked, iteration 0
    Main task is not blocked, iteration 1
    Main task is not blocked, iteration 2
    Main task is not blocked, iteration 3
    Main task is not blocked, iteration 4
    Background task completed
    Main task completed
 */

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Main task started");

        // Start a background task that takes 5 seconds to complete
        Task backgroundTask = DoBackgroundWorkAsync();

        // Continue executing the main task while the background task runs
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main task is not blocked, iteration " + i);
            await Task.Delay(1000); // wait for 1 second
        }

        // Wait for the background task to complete
        await backgroundTask;

        Console.WriteLine("Main task completed");
    }

    static async Task DoBackgroundWorkAsync()
    {
        Console.WriteLine("Background task started");
        await Task.Delay(5000); // simulate 5 seconds of work
        Console.WriteLine("Background task completed");
    }
}