using System;

/*
 * Program to get 10 numbers from the user and count the negativ and positive numbers.
 */

namespace CountNumbers
{
    public class Numbers
    {
        private int _positive;
        private int _negative;

        public int Positive
        {
            get { return _positive; }
            set { _positive = value; }
        }

        public int Negative
        {
            get { return _negative; }
            set { _negative = value; }
        }

        public Numbers()
        {
            Positive = 0;
            Negative = 0;
        }

        public void GetANumber(int item)
        {
            if (item < 0)
            {
                Negative++;
            }

            else if (item > 0)
            {
                Positive++;
            }
        }
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];

            Numbers numbers = new Numbers();

            Console.WriteLine("Kérem adjon meg 10 db számot (lehet pozitív és negatív is!");
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. szám: ");

                try
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba! Csak számérték adható meg!", ex.Message);
                }

            }

            foreach (int item in array)
            {
                numbers.GetANumber(item);
            }

            Console.WriteLine($"Positive numbers: {numbers.Positive}");
            Console.WriteLine($"Negative numbers: {numbers.Negative}");
        }
    }
}