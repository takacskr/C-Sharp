using System;

public class Szamolo
{
    // Private integer field to store the current value
    private int szam;

    // Delegate definition inside Szamolo
    // This delegate represents a method that takes an int parameter and returns void
    public delegate void SzamValtozottEventHandler(int ujErtek);

    // Event declaration using the delegate type
    // The "?" symbol after the event type indicates that the event can be null
    public event SzamValtozottEventHandler? SzamValtozott;

    // Constructor to initialize the szam field
    public Szamolo() => szam = 0;

    // Method to increment the szam field and raise the SzamValtozott event
    public void Novel()
    {
        // Increment the szam field
        szam++;

        // Raise the SzamValtozott event, passing the new value of szam as an argument
        // The null-conditional operator?. ensures that the event is not null before invoking it
        // Calling the delegate instance with the specified argument
        SzamValtozott?.Invoke(szam);
    }
}

public class Program
{
    // Main method, the entry point of the program
    public static void Main()
    {
        // Static method to handle the SzamValtozott event
        // This method takes an int parameter and writes a message to the console
        static void SzamValtozottKezelo(int ujErtek)
        {
            Console.WriteLine("A szám új értéke: " + ujErtek);
        }

        // Create an instance of the Szamolo class
        Szamolo szamolo = new Szamolo();

        // Subscribe to the SzamValtozott event by adding the SzamValtozottKezelo method as an event handler
        szamolo.SzamValtozott += SzamValtozottKezelo;

        // Call the Novel method to increment the szam field and raise the SzamValtozott event
        szamolo.Novel();
    }
}