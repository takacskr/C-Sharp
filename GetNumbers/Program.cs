using System;

namespace CountNumbers
{
    public class Numbers
    {
        public int Positive { get; private set; }
        public int Negative { get; private set; }

        public void AddNumber(int number)
        {
            if (number < 0)
            {
                Negative++;
            }
            else if (number > 0)
            {
                Positive++;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    int number = int.Parse(Console.ReadLine());
                    numbers.AddNumber(number);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }

            Console.WriteLine($"Positive numbers: {numbers.Positive}");
            Console.WriteLine($"Negative numbers: {numbers.Negative}");
        }
    }
}
