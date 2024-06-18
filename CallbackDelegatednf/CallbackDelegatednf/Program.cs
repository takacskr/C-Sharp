using System;

// Definiáljunk egy delegált típust a callback függvény számára
delegate void Callback(int value);

class Program
{
    // Ez az első callback függvény, amit átadunk PerformCallback-nek
    static void FirstCallback(int value)
    {
        Console.WriteLine("Első callback meghívva: " + value);
    }

    // Ez a második callback függvény, amit átadunk PerformCallback-nek
    static void SecondCallback(int value)
    {
        Console.WriteLine("Második callback meghívva: " + value);
    }

    // Ez a függvény fogja meghívni a kapott callback függvényt
    static void PerformCallback(int x, Callback callback)
    {
        // Hívjuk meg a callback függvényt a paraméterrel
        callback(x);
    }

    static void Main(string[] args)
    {
        // Példányosítunk egy Callback típusú változót átadjuk neki a FirstCallback majd a SecondCallback függvényt
        // Utána hívjuk meg a PerformCallback függvényt és adjuk át neki a callback függvényeket

        Callback aCallback = new Callback(FirstCallback);
        PerformCallback(42, aCallback);

        aCallback = new Callback(SecondCallback);
        PerformCallback(73, aCallback);
    }
}
