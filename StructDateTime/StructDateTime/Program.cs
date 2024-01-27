using System;
using MyLibrary; // az osztálykönyvtár névtere

namespace TestApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            ClassLib.PrintHello();
            Console.ReadKey();
        }
    }
}