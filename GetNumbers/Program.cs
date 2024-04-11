using System;
using System.Runtime.CompilerServices;

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

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérem adja meg a(z) {i}. számot: ");
                array[i] = int.Parse(Console.ReadLine());
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