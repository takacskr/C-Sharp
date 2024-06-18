using System;

public class Program
{
    public class Szamolo
    {
        private int szam;

        public delegate void SzamValtozottEventHandler(int ujErtek); // Delegate definition inside Szamolo

        public event SzamValtozottEventHandler? SzamValtozott;

        public Szamolo()
        {
            szam = 0;
        }

        public void Novel()
        {
            szam++;
            SzamValtozott?.Invoke(szam);
        }
    }

    static void SzamValtozottKezelo(int ujErtek) // Method definition remains outside
    {
        Console.WriteLine("A szám új értéke: " + ujErtek);
    }

    public static void Main()
    {
        Szamolo szamolo = new Szamolo();
        szamolo.SzamValtozott += SzamValtozottKezelo;

        szamolo.Novel();
    }
}
