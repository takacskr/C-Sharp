public record Person(string FirstName, string LastName, int Age);

class Program
{
    static void Main()
    {
        var person1 = new Person("John", "Doe", 30);

        // Value equality
        var person2 = new Person("John", "Doe", 30);
        Console.WriteLine(person1 == person2); // True

        // Immutability
        // person1.FirstName = "Jane"; // Compilation error

        // With-expression
        var person3 = person1 with { Age = 31 };
        Console.WriteLine(person3.Age); // 31

        // Deconstruction
        var (firstName, lastName, age) = person1;
        Console.WriteLine(firstName); // John
        Console.WriteLine(lastName);  // Doe
        Console.WriteLine(age);       // 30
    }
}
