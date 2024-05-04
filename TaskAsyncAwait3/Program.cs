using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Program indítása...");

        // Kép letöltése aszinkron módon
        Task<byte[]> downloadTask = DownloadImageAsync();

        // Fő szál közben más művelet végrehajtása
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Más művelet {i + 1}. végrehajtása...");
            await Task.Delay(500); // Várakozás fél másodpercig
        }

        // Kép letöltésének befejeződése
        byte[] imageBytes = await downloadTask;

        // Kép megjelenítése
        Console.WriteLine("Kép letöltése befejeződött.");
    }

    static async Task<byte[]> DownloadImageAsync()
    {
        Console.WriteLine("Kép letöltése elkezdődött...");

        // Kép letöltésének szimulálása 3 másodpercig
        await Task.Delay(3000);

        Console.WriteLine("Kép letöltése befejeződött.");
        // Valós kép adat helyett most üres tömböt adunk vissza
        return new byte[0];
    }
}
