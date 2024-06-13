using System;

class OutExample
{
    static void Square(int number, out int result)
    {
        result = number * number;
    }

    static void Main(string[] args)
    {
        int num = 5;
        int squaredNum;

        // Notice how 'squaredNum' is not initialized here
        Square(num, out squaredNum);

        Console.WriteLine($"The square of {num} is {squaredNum}");
    }
}
