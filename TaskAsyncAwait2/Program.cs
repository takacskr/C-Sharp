using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Program indítása..."); // 1.

        // Kép letöltése aszinkron módon
        Task<byte[]> downloadTask = DownloadImageAsync();

        // Más művelet végrehajtása közben
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Más művelet {i + 1}. végrehajtása..."); // 2.
            await Task.Delay(500); // Várakozás fél másodpercig
        }

        // Kép letöltésének befejeződése
        byte[] imageBytes = await downloadTask;

        // Kép megjelenítése
        Console.WriteLine("Kép letöltése befejeződött."); // 4.
    }

    static async Task<byte[]> DownloadImageAsync()
    {
        await Task.Delay(3000); // 3 másodperc várakozás szimulálás céljából
        Console.WriteLine("Kép letöltése befejeződött (szimulált)."); // 3.
        // Itt lehetne valódi kép letöltése HTTP kéréssel, de most csak üres tömböt adunk vissza
        return new byte[0]; // Üres tömb visszaadása, nincs valós kép adat
    }
}
