namespace gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");

            // The _ symbol is used to indicate that the result of the int.Parse() method is not actually being used
            _ = int.Parse(Console.ReadLine());
        }
    }
}
