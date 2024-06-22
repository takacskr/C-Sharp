using System;

public class Program
{
    public static void Main()
    {
        Action<int> act = x => Console.WriteLine(x);
        act(1250);
    }
}