using System;

public static class Test
{
    public static void Swap<T>(ref T x, ref T y)
    {
        T tmp = x;
        x = y;
        y = tmp;
    }
}

public class Program
{
    public static void Main()
    {
        int x = 10;
        int y = 20;
        string gyumolcs1 = "alma";
        string gyumolcs2 = "banan";

        Test.Swap<int>(ref x, ref y);
        Console.WriteLine($"x erteke: {x} és y erteke: {y}");

        Test.Swap<string>(ref gyumolcs1, ref gyumolcs2);
        Console.WriteLine($"gyumolcs1 erteke: {gyumolcs1} és gyumolcs2 erteke: {gyumolcs2}");
    }
}