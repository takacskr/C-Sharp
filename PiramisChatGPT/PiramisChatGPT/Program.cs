using System;

class Program
{
    static void Main()
    {
        int rows = 7; // Piramis sorainak száma

        for (int i = 1; i <= rows; i++)
        {
            int number = i;
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number + " ");
                number += i;
            }
            Console.WriteLine();
        }
    }
}
