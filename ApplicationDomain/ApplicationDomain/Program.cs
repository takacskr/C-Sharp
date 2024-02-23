using System;
class Program
{
    static void Main(string[] args)
    {
        AppDomain currAD = AppDomain.CurrentDomain;
        Console.WriteLine(currAD.FriendlyName);
        Console.ReadKey();
    }
}