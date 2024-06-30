using System;

class Test
{
    public Action<int>? act;

    public void Method()
    {
        int local = 11;
        act = (x) => Console.WriteLine(x * local);
        local = 100;
    }
}

public class Program
{
    public static void Main()
    {
        Test t = new Test();
        t.Method();
        t.act(100);
    }
}