namespace Lambda4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<bool> func = () => 3 < 4; // True

            Console.WriteLine(func());
        }
    }
}
