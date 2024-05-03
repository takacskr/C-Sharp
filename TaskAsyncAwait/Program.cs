using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Program indítása...");

        // Kép letöltése aszinkron módon
        Task<byte[]> downloadTask = DownloadImageAsync("https://picsum.photos/200");

        // Más művelet végrehajtása közben
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Más művelet {i + 1}. végrehajtása...");
            await Task.Delay(500); // Várakozás fél másodpercig
        }

        // Kép letöltésének befejeződése
        byte[] imageBytes = await downloadTask;

        // Kép mentése fájlba
        string imagePath = "downloaded_image.jpg";
        File.WriteAllBytes(imagePath, imageBytes);
        Console.WriteLine($"Letöltött kép elmentve ide: {imagePath}");

        Console.WriteLine("Program vége.");
    }

    static async Task<byte[]> DownloadImageAsync(string url)
    {
        Console.WriteLine("Kép letöltése elkezdődött...");
        using (var httpClient = new HttpClient())
        {
            byte[] imageBytes = await httpClient.GetByteArrayAsync(url);
            Console.WriteLine("Kép letöltése befejeződött.");
            return imageBytes;
        }
    }
}
