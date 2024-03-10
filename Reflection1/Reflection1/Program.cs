using System;
class Test
{
}
class Program
{
    static public void Main(string[] args)
    {
        Test t = new Test();
        Type type = t.GetType();

        Console.WriteLine(type); // Test
        
        Console.ReadKey();
    }
}