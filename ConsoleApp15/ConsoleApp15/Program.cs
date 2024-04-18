public class Diak
{
    // Adattag (field)
    private string _nev;

    // Tulajdonság (property) a név lekérdezésére és beállítására
    public string Nev
    {
        get { return _nev; }
        set
        {
            // Példa validáció
            if (!string.IsNullOrEmpty(value))
            {
                _nev = value;
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
        Diak diak = new();

        // Property használata
        diak.Nev = "John Doe";  // A Setter meghívása
        Console.WriteLine("Diák neve: " + diak.Nev);  // A Getter meghívása

        // Érvénytelen név beállítása
        diak.Nev = "";  // A Setter érvénytelen név esetén hibát jelez
    }
}
