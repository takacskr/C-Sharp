using System;
using System.Reflection.Metadata;
using System.Threading.Tasks;


class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Main task started");

        SetImage("asd", null); // runs in bg, next line starts immidiately

        int x = await DoBackgroundWorkAsync(); // wait for result, set result as x

        await SetImage("asd", null); // wait for image to be updated, then next line

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Main task is not blocked, iteration " + i);
            await Task.Delay(1500);
        }

        Console.WriteLine("Main task completed");
        Console.ReadLine();
    }

    static async Task<int> DoBackgroundWorkAsync()
    {
        Console.WriteLine("Background task started");
        await Task.Delay(5000);
        Console.WriteLine("Background task completed");

        return 0;
    }

    static async Task SetImage(string url, object targetContainerImg)
    {
        Console.WriteLine("Background task started");
        await Task.Delay(5000); // download image from url
        Console.WriteLine("Background task completed");

        // targetContainerImg.image = urlResultImage.bytes;
    }
}