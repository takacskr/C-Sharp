namespace Lambda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> stringLengthFunc = s => s.Length;

            int length = stringLengthFunc("Hello World!");

            Console.WriteLine(length);
        }
    }
}
