using System;
using System.Threading.Tasks;

namespace AsyncDelegateDemo
{
    class Program
    {
        // Define a delegate type
        delegate Task<int> MyDelegateAsync(int x, int y);

        static async Task Main()
        {
            // Create an instance of the delegate
            MyDelegateAsync myDelegate = async (x, y) =>
            {
                // Simulate some asynchronous operation
                await Task.Delay(1000);

                // Return the result
                return x + y;
            };

            Console.WriteLine("Calling the delegate asynchronously...");

            // Call the delegate asynchronously
            int result = await myDelegate(3, 4);

            Console.WriteLine($"Result of the delegate: {result}");
        }
    }
}
