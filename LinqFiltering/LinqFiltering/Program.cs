using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string[] poem = new string[]
        {
            "Indul a görög aludi",
            "Ez egy idézet",
            "Zúg a Volga",
            "Mi folyik Gyöngyösön?"
        };

        foreach (string line in poem)
        {
            foreach (string word in line.Split(' '))
            {
                if (word.StartsWith('g'))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}