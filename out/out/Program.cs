using System;

namespace OutKW
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(10, 8, out int result);
            Console.WriteLine($"Az eredmény: {result}");
        }

        static void Calculate(int a, int b, out int result)
        {
            result = a + b;
        }
    }
}