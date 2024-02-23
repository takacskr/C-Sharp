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
        Test.Method();
        Test.act(100);
        Console.ReadKey();
    }
}