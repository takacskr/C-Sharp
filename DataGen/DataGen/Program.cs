using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Program
{
    static public void Main(string[] args)
    {
        string fileName = args[0];
        int count = int.Parse(args[1]);

        List<string> firstNames = new List<string>()
        {
            "István", "Judit", "Béla", "Viktória", "Balázs", "Miklós", "Anna",
            "Sándor", "József", "Beáta", "Benedek", "Lilla", "Andrea", "Szilvia",
            "Katalin", "Imola", "János", "Károly", "Zoltán", "Gábor", "Csilla",
            "Orsolya", "Kinga", "Edina", "Zsolt", "Ádám", "László", "Endre",
            "Máté", "Márk", "Mária", "Magdolna", "Kelemen", "Csaba", "Ede",
            "Péter", "András", "Bernadett", "Erika", "Zsófia", "Adrienn", "Dániel"

        };

        List<string> lastNames = new List<string>()
        {
            "Reiter", "Simonits", "Kovács", "Rákosi", "Kiss", "Nagy", "Tóth",
            "Hajdu", "Simon", "Gyömbér", "Szabó", "Budai", "Cseh", "Ádám",
            "Árvay", "Balogh", "Bánfalvi", "Barna", "Báthory", "Polgár", "Zimány",
            "Zsoldos", "Varga", "Török", "Szász", "Szarvas", "Pusztai", "Pásztor",
            "Papp", "Lóczi", "Kertész", "Horváth", "Fülöp", "Bakos", "Adorján",
            "Farkas", "Gazdag", "Maros", "Virág", "Csóka", "Gyenes", "Busa"
        };

        List<string> states = new List<string>()
        {
            "Bács-Kiskun", "Baranya", "Békés", "Borsod-Abaúj-Zemplén", "Csongrád",
            "Fejér", "Győr-Moson-Sopron", "Hajdú-Bihar", "Heves", "Jász-Nagykun-Szolnok",
            "Komárom-Esztergom", "Nógrád", "Pest", "Somogy", "Szabolcs-Szatmár-Bereg",
            "Tolna", "Vas", "Veszprém", "Zala"
        };

        List<string> jobs = new List<string>()
        {
            "programozó", "buszvezető", "taxisofőr", "kőműves", "könyvelő", "bolti eladó",
            "vállalkozó", "politikus", "börtönőr", "író", "zenész", "színész", "mérnök",
            "favágó", "építész", "kertész", "villanyszerelő", "rendőr", "orvos", "ügyvéd",
            "ács", "gyógszerész", "szakács", "asztalos", "cipész", "katona", "matematikus",
            "bilógus", "pszichológus", "tanár", "portás", "biztonsági őr", "fogász", "vegyész",
            "raktárkezelő", "titkárnő", "postás", "óvónő", "festő és mázoló", "ápoló", "újságíró",
            "védőnő", "takarító", "pap", "sportoló", "kalauz", "autószerelő", "fizikus"
        };

        Random r = new Random();
        StreamWriter writer = new StreamWriter(fileName);

        for (int i = 0; i < count; ++i)
        {
            writer.WriteLine(
                lastNames[r.Next(0, lastNames.Count)] + " " +
                firstNames[r.Next(0, firstNames.Count)] + " " +
                r.Next(18, 100).ToString() + " " +
                jobs[r.Next(0, jobs.Count)] + " " +
                states[r.Next(0, states.Count)]);
        }

        writer.Close();

        Console.WriteLine("Success");
    }
}