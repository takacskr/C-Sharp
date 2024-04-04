﻿using System;

class Program
{
    static void Main()
    {
        string szamSzoveg = "123%";

        // int.Parse() használata
        try
        {
            int szam = int.Parse(szamSzoveg);
            Console.WriteLine("Az int.Parse() által konvertált szám: " + szam);
        }
        catch (FormatException)
        {
            Console.WriteLine("Hiba történt az int.Parse() konverzió során.");
        }
        finally
        {
            // Ez a blokk mindig végrehajtódik, függetlenül attól, hogy volt-e kivétel vagy sem.
            // Ideális hely az erőforrások felszabadítására vagy tisztítási műveletek végrehajtására.
            Console.WriteLine("A finally blokk végrehajtódott.");
        }

        // int.TryParse() használata
        int eredmeny;

        if (int.TryParse(szamSzoveg, out eredmeny))
        {
            Console.WriteLine("Az int.TryParse() által konvertált szám: " + eredmeny);
        }
        else
        {
            Console.WriteLine("Hiba történt az int.TryParse() konverzió során.");
        }
    }
}
