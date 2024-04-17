using System;
using MyLibrary; // a használt osztálykönyvtár névtere
using CalculateLibrary; // a használt osztálykönyvtár névtere

namespace TestApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            ClassLib.PrintHello();

            // We msut declare a variable for the result
            int result;
            Calculate.Multiple(4, 5, out result);
            Console.WriteLine(result);
        }
    }
}