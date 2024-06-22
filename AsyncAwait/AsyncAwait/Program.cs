// Import necessary namespaces
using System;
using System.Net.Http;
using System.Threading.Tasks;

// Define a class called Example
public class Example
{
    // Define the Main method, which is the entry point of the program
    public static async Task Main()
    {
        // Print a message to the console
        Console.WriteLine("Main thread does some work.");

        // Call the DownloadContentAsync method and wait for it to complete
        // The await keyword allows the program to continue executing other code
        // while waiting for the operation to complete
        string result = await DownloadContentAsync("https://example.com");

        // Print the downloaded content to the console
        Console.WriteLine("Downloaded content:");
        Console.WriteLine(result);
    }

    // Define the DownloadContentAsync method, which downloads content from a URL
    public static async Task<string> DownloadContentAsync(string url)
    {
        // Create a new instance of HttpClient, which is used to send HTTP requests
        using (HttpClient client = new HttpClient())
        {
            // Send a GET request to the specified URL and retrieve the response content as a string
            // The await keyword is used to wait for the operation to complete
            string content = await client.GetStringAsync(url);

            // Return the downloaded content as a string
            return content;
        }
    }
}

/*
    By using a using statement, you can ensure that objects are properly cleaned up and resources are released,
    even if an exception is thrown. This helps prevent memory leaks and other issues related to resource management.
*/