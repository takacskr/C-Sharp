using System;

class IsPrime
{
    static bool IsPrimeCheck(int number, out int divisor)
    {
        divisor = 2; // Start checking for divisibility from 2
        while (divisor * divisor <= number)
        {
            if (number % divisor == 0)
            {
                return false; // Not prime if divisible by another number
            }

            divisor++;
        }

        return true; // Prime if no divisors found
    }

    static void Main(string[] args)
    {
        Console.Write("Give the number: ");
        string snum = Console.ReadLine();

        int num;
        int potentialDivisor;

        if (int.TryParse(snum, out num))
        {
            if (IsPrimeCheck(num, out potentialDivisor))
            {
                Console.WriteLine($"{num} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number. Divisible by {potentialDivisor}");
            }
        }
    }
}