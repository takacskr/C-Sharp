namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello, World!";

            Console.WriteLine( s1.Contains("W") );
            Console.WriteLine( s1.EndsWith("!") );
            Console.WriteLine( s1.IndexOf("o") );
        }
    }
}
