using System;
<<<<<<< HEAD

/*
 * Program to get 10 numbers from the user and count the negativ and positive numbers.
 */
=======
>>>>>>> 55d4553cd3125abb218336274f977bbe4911ee23

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

<<<<<<< HEAD
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

=======
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    int number = int.Parse(Console.ReadLine());
                    numbers.AddNumber(number);
                }
>>>>>>> 55d4553cd3125abb218336274f977bbe4911ee23
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
