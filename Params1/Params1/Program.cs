using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = Sum(10, 20, 30, 40, 50);

            PrintValues("Hello", "World");
            Console.WriteLine(total);

            Console.ReadLine();
        }

        static void PrintValues(params string[] values)
        {
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
        }

        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total;
        }
    }
}
