using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace LINQLet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] poem = new string[]
            {
                 "Ej mi a kõ! tyúkanyó, kend",
                 "A szobában lakik itt bent?",
                 "Lám, csak jó az isten, jót ád,",
                 "Hogy fölvitte a kend dolgát!"
            };

            var result = from line in poem
                         let words = line.Split(' ')
                         from word in words
                         select word;

            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
