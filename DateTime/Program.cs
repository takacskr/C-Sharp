internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Add meg a neved: ");
        string name = Console.ReadLine();

        Console.WriteLine("Add meg a születési dátumodat az alábbi formátumban:");
        Console.WriteLine("ÉÉÉÉ.HH.NN");
        DateTime birth = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Köszönöm!");

        double age = DateTime.Now.Subtract(birth).Days / 365.25;

        Console.WriteLine($"Mostani dátum: {DateTime.Now}");
        Console.WriteLine($"Kedves {name}, {(int)age} éves vagy.");
    }
}