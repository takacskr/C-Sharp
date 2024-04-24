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
        // Példányosítsunk egy Callback típusú változót és adjuk át neki a FirstCallback függvényt
        Callback firstCallback = new Callback(FirstCallback);
        // Példányosítsunk egy Callback típusú változót és adjuk át neki a SecondCallback függvényt
        Callback secondCallback = new Callback(SecondCallback);

        // Hívjuk meg a PerformCallback függvényt és adjuk át neki a callback függvényeket
        PerformCallback(42, firstCallback);
        PerformCallback(73, secondCallback);
    }
}
