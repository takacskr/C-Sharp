using System;

namespace CountNumbers
{
    public class Counter<T> where T : IComparable<T>
    {
        public int Positive { get; private set; }
        public int Negative { get; private set; }
        public int Zero { get; private set; }

        public Counter()
        {
            Positive = 0;
            Negative = 0;
            Zero = 0;
        }

        public void AddNumber(T value)
        {
            if (typeof(T) == typeof(int))
            {
                int number = (int)(object)value;
                if (number < 0)
                {
                    Negative++;
                }
                else if (number > 0)
                {
                    Positive++;
                }
                else
                {
                    Zero++;
                }
            }
            else
            {
                throw new ArgumentException("Type must be int");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Counter<int>();

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
            Console.WriteLine($"Zero: {numbers.Zero}");
        }
    }
}