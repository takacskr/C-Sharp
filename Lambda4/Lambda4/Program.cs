namespace Lambda4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<bool> func = () => true;

            Console.WriteLine(func());
        }
    }
}
