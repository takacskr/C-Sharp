using System;
using ClassLibrary1;

struct Test
{
    public int x;
    public override string ToString()
    {
        return "X == " + x.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Test myTest = new Test { x = 10 };
        Console.WriteLine(myTest.ToString()); // Output: X == 10
        Class1.PrintHello();
    }
}