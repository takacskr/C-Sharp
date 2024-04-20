using System;

static class Test
{
    public static Action<int> act;
    public static void Method()
    {
        int local = 11;
        act = (x) => Console.WriteLine(x * local);
        local = 100;
    }
}
class Program
{
    static void Main()
    {
        Test.Method(); // The variable x has no value, yet.
        Test.act(100); // 10000

        Console.ReadKey();
    }
}