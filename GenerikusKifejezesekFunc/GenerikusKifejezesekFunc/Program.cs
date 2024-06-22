using System;

public class Program
{
    public static void Main()
    {
        Func<int, int, bool> func = (x, y) => (x % y == 0);
        Console.WriteLine(func(10, 5));
    }
}