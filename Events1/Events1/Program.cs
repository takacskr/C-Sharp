using System.Reflection.Metadata;

class Test
{
    // Esemény delegált típusának definiálása
    // Ez egy delegált típus, amely meghatározza az esemény kezelője által elfogadott paramétereket
    // és visszatérési értéket
    // Egy olyan delegált típus, amely egy metódus aláírását határozza meg, melynek egy string típusú paramétere van
    // és nincs visszatérési értéke
    /* A TestStatusChange esemény az EventHandlerDelegate típusú delegátumot reprezentálja. Ez azt jelenti, hogy az eseményre
    feliratkozni csak olyan metódusokkal lehet, amelyek megfelelnek az EventHandlerDelegate delegátum aláírásának.
    Ezen delegátum aláírása meghatározza, hogy az esemény kiváltásakor milyen paramétereket vár és milyen
    visszatérési értékkel rendelkezik az eseménykezelő metódus. */
    public delegate void EventHandlerDelegate(string message); // Ez a delegát meghatározza, az eseményre feliratkozó metódus(ok) formátumát


    // Az esemény deklarálása a delegált típus alapján
    // A TestStatusChange esemény egy olyan delegált típust használ,
    // amely egy string típusú paramétert vár
    /* Tehát a TestStatusChange esemény egy olyan lehetőséget kínál más osztályoknak, hogy feliratkozzanak az eseményre,
    és olyan metódusokat rendeljenek hozzá, amelyek megfelelnek az EventHandlerDelegate delegátum aláírásának.
    Amikor az esemény kiváltódik, az összes feliratkozott metódus végrehajtódik a delegált aláírásában meghatározott
    paraméterekkel. Ezáltal az eseménykezelés egy egyszerű és hatékony módszere lehet a kommunikációnak és az események
    kezelésének különböző részei között a programban. */

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
        // Ha nincs regisztrált eseménykezelő metódus, az esemény null értéket fog tartalmazni
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
