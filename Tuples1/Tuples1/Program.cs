using System;

class TupleExample
{
    static void Main(string[] args)
    {
        // Create a tuple with three elements
        var person = new Tuple<string, int, string>("John", 30, "Developer");

        // Access the elements of the tuple
        Console.WriteLine("Name: " + person.Item1);
        Console.WriteLine("Age: " + person.Item2);
        Console.WriteLine("Occupation: " + person.Item3);

        // Create a tuple with two elements
        var coordinates = new Tuple<int, int>(10, 20);

        // Access the elements of the tuple
        Console.WriteLine("X: " + coordinates.Item1);
        Console.WriteLine("Y: " + coordinates.Item2);
    }
}