using System;

namespace ConsoleAppExtensionMethod
{
    public static class StringHelper
    {
        public static void Print(this string s)
        {
            Console.WriteLine(s);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "ez egy string";
            str.Print();

            StringHelper.Print(str);

            Console.ReadKey();
        }
    }
}

/* A "this" kulcsszó jelöli a kiterjesztési metódust, és a string "s" paraméter az az objektum,
amelyen a kiterjesztési metódus meghívódik. A "this string s" kifejezés azt jelenti,
hogy a Print metódus kiterjeszti a string típust, és az "s" paraméteren keresztül
érhető el az az objektum, amelyre a metódust meghívják.

Amikor a kiterjesztett metódust meghívják egy string objektumon, a "this" kulcsszó által jelölt
paraméter azon az objektumon fog műveletet végrehajtani, amelyen a metódust meghívták.
A "this" kulcsszó tehát a metódus meghívásakor használt objektumra mutat.
Ebben az esetben a "s" változóra mutat, amely egy string objektumot tartalmaz. */