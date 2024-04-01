using System;

namespace OutKW
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(out int result);
            Console.WriteLine($"Az eredmény: {result}");
        }

        static void Calculate(out int result)
        {
            result = 10;
        }
    }
}