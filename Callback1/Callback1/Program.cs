using System;

// Definiáljunk egy delegált típust a callback függvény számára
delegate void Callback(int value);

class Program
{
    // Ez a függvény fogja meghívni a kapott callback függvényt
    static void PerformCallback(int x, Callback callback)
    {
        // Meghívjuk a callback függvényt a paraméterrel
        callback(x);
    }

    // Ez a tényleges callback függvény, amit átadunk PerformCallback-nek
    static void MyCallback(int value)
    {
        Console.WriteLine("Callback meghívva: " + value);
    }

    static void Main(string[] args)
    {
        // Példányosítunk egy Callback típusú változót és átadjuk neki a MyCallback függvényt
        Callback myCallback = new Callback(MyCallback);

        // Hívjuk meg a PerformCallback függvényt és adjuk át neki a callback függvényt
        PerformCallback(42, myCallback);

        // Kimenet: "Callback meghívva: 42"
    }
}
