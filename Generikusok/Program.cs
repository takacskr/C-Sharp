using System;

class Pair<T1, T2>
{
    public T1 First { get; set; }
    public T2 Second { get; set; }

    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Definiálunk egy Pair generikus típust, amely két stringet tárol
        Pair<string, string> nevek = new Pair<string, string>("John", "Doe");

        // Kiírjuk az első és második elemet
        Console.WriteLine($"Első név: {nevek.First}, Második név: {nevek.Second}");

        // Definiálunk egy Pair generikus típust, amely két egész számot tárol
        Pair<int, int> szamok = new Pair<int, int>(10, 20);

        // Kiírjuk az első és második számot
        Console.WriteLine($"Első szám: {szamok.First}, Második szám: {szamok.Second}");
    }
}
