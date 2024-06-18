using System;

public delegate void SzamValtozottEventHandler(int ujSzam);

public class EventSource
{
    private int szam;

    public event SzamValtozottEventHandler? SzamMegvaltozott;

    public EventSource()
    {
        szam = 0;
    }

    public void DoValami()
    {
        szam += DateTime.Now.Second;

        // Esemény kiváltása
        SzamMegvaltozott?.Invoke(szam);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var eventSource = new EventSource();

        // Feliratkozás az eseményre
        eventSource.SzamMegvaltozott += EventSource_SzamMegvaltozott;

        eventSource.DoValami(); // Esemény kiváltása
        eventSource.DoValami(); // Esemény kiváltása
        eventSource.DoValami(); // Esemény kiváltása
    }

    static void EventSource_SzamMegvaltozott(int ujSzam)
    {
        Console.WriteLine("A szám megváltozott: {0}", ujSzam);
    }
}

/*
    Ebben a példában az EventSource osztály egy SzamValtozott nevű eseményt definiál, amely akkor aktiválódik,
    amikor a szam tulajdonság értéke megváltozik. A Program osztály feliratkozik erre az eseményre,
    és az EventSource_SzamMegvaltozott metódust hívja meg, amikor az esemény bekövetkezik.
*/