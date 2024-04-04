using System;
using MyLibrary; // az osztálykönyvtár névtere
using CalculateLibrary;

namespace TestApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            ClassLib.PrintHello();
            Console.WriteLine(Calculate.Multiple(4, 5));
        }
    }
}