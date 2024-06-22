using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Example
{
    public static async Task Main()
    {
        Console.WriteLine("Main thread does some work.");

        string result = await DownloadContentAsync("https://example.com");

        Console.WriteLine("Downloaded content:");
        Console.WriteLine(result);
    }

    public static async Task<string> DownloadContentAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            string content = await client.GetStringAsync(url);
            return content;
        }
    }
}
