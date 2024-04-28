namespace gyak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine($"You entered the {number} number.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
        }
    }
}
