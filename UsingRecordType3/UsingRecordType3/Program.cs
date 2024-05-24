using System;

public record Person(string FirstName, string LastName, int Age);

class Program
{
    static void Main(string[] args)
    {
        // Create a new Person record
        var person = new Person("John", "Doe", 30);

        // Access the properties
        Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");

        // Modify the properties
        person = person with { Age = 31 };

        // Access the modified properties
        Console.WriteLine($"Modified Age: {person.Age}");
    }
}