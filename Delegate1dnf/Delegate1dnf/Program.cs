using System;

public class Program
{
    delegate int TestDelegate(int x);

    public static void Main()
    {
        int Pow(int x)
        {
            return (x * x);
        }

        TestDelegate dlgt = Pow;
        Console.WriteLine(dlgt(10));
    }
}