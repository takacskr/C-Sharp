using System;
using System.Reflection; // erre a névtérre szükség van
class Test
{
}
class Program
{
    static public void Main(string[] args)
    {
        Type type = Assembly.GetCallingAssembly().GetType("Test");
        var t = Activator.CreateInstance(type);

        Console.WriteLine(t.GetType()); // Test

        Console.ReadKey();
    }
}