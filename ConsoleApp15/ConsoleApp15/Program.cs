public class Diak
{
    // Adattag (field)
    private string nev;

    // Property a név lekérdezésére és beállítására
    public string Nev
    {
        get { return nev; }
        set
        {
            // Példa validáció
            if (!string.IsNullOrEmpty(value))
            {
                nev = value;
            }
            else
            {
                Console.WriteLine("Hiba: Érvénytelen név!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Példányosítás
        Diak diak = new Diak();

        // Property használata
        diak.Nev = "John Doe";  // A setter meghívása
        Console.WriteLine("Diák neve: " + diak.Nev);  // A getter meghívása

        // Érvénytelen név beállítása
        diak.Nev = "";  // A setter érvénytelen név esetén hibát jelez
    }
}
