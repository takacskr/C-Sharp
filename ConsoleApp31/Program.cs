using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Definiálunk egy List generikus típust, amely egész számokat tárol
        List<int> egeszLista = new List<int>();

        // Hozzáadunk elemeket a listához
        egeszLista.Add(10);
        egeszLista.Add(20);

        // Végigmegyünk a listán és kiírjuk az összes elemet
        foreach (int elem in egeszLista)
        {
            Console.WriteLine(elem);
        }
    }
}
