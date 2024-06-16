using System;
namespace TestApp
{
    class Program
    {
        static public double Pow(double x, int y)
        {
            if (y == 0)
            {
                return 1.0;
            }
            else
            {
                return x * Pow(x, y - 1);
            }
        }
        static void Main(string[] args)
        {
            double result = Pow(2, 10);
            Console.WriteLine(result); // 1024
            Console.ReadKey();
        }
    }
}

/*
    For example, when x = 2 and y = 3, the formula becomes:

    return 2 * Pow(2, 2);

    Which is equivalent to:

    return 2 * (2 * Pow(2, 1));

    And further:

    return 2 * (2 * (2 * Pow(2, 0)));

    Since Pow(2, 0) returns 1, the final result is:

    return 2 * (2 * (2 * 1));
 */