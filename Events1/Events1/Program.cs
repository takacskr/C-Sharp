class Test
{
    // Esemény delegált típusának definiálása
    // Ez egy delegált típus, amely meghatározza az esemény kezelője által elfogadott paramétereket
    // és visszatérési értéket
    public delegate void EventHandlerDelegate(string message);

    // Az esemény deklarálása a delegált típus alapján
    // A TestStatusChange esemény egy olyan delegált típust használ,
    // amely egy string típusú paramétert vár
    public event EventHandlerDelegate TestStatusChange;

    // Privát adattag az osztályban
    private int data = 10;

    // Az osztály publikus tulajdonsága, amely olvasható és írható
    public int Data
    {
        get { return data; }
        set
        {
            // Az adattag értékének beállítása
            data = value;

            // Az osztályhoz tartozó esemény kiváltása, ha az adattag megváltozik
            this.OnStatusChange();
        }
    }

    // Privát metódus az osztályban, amely kiváltja az eseményt
    private void OnStatusChange()
    {
        // Az eseményekkel rendelkező objektumoknak lehetőségük van regisztrálni eseménykezelő metódusokat az eseményre
        // Ellenőrzés, hogy van-e regisztrált eseménykezelő.
        // Ha nincs regisztrált eseménykezelő, az esemény null értéket fog tartalmazni
        if (TestStatusChange != null)
        {
            // Az esemény kiváltása és az üzenet továbbítása az eseménykezelőknek
            TestStatusChange("Az osztály állapota megváltozott!");
        }
    }
}

internal class Program
{
    static void Main()
    {
        // A Test osztály példányosítása
        Test test = new Test();

        // Regisztrálunk egy eseménykezelőt az eseményre
        test.TestStatusChange += TestStatusChangeHandler;

        // Módosítjuk az adattag értékét
        test.Data = 20; // Ez meghívja az eseményt
    }

    // Eseménykezelő metódus
    static void TestStatusChangeHandler(string message)
    {
        Console.WriteLine("Esemény kiírása: " + message);
    }
}
