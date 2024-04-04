using System;

public static class StringExtensions
{
    public static string Reverse(this string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

class Program
{
    static void Main()
    {
        string szoveg = "Hello World";
        string forditott = szoveg.Reverse();
        Console.WriteLine("Fordított szöveg: " + forditott); // "dlroW olleH"
    }
}
