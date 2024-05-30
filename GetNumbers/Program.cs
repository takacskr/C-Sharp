using System;

namespace CountNumbers
{
    public class Numbers
    {
        private int positive = 0;
        private int negative = 0;

        public int Positive { get; set; } = 0;
        public int Negative { get; set; } = 0;

        public Numbers()
        {
            Positive = positive;
            Negative = negative;
        }

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

            Console.WriteLine("Please enter 10 numbers (they can be positive or negative):");

            for (int i = 1; i <= 10; i++)
            {
                int number;
                while (true)
                {
                    Console.Write($"Enter number {i}: ");
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        numbers.AddNumber(number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }

            Console.WriteLine($"Positive numbers: {numbers.Positive}");
            Console.WriteLine($"Negative numbers: {numbers.Negative}");
        }
    }
}