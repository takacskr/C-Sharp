using System;

namespace TryParseTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Give me a number: ");

            /*
            Attempts to convert a string to an integer.
            If the conversion is successful, it sets the number variable
            to the converted value and returns true.
            If the conversion fails, it returns false.
            */
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"The number you've given: {number}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
