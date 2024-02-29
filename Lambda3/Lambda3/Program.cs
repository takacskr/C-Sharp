namespace Lambda3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> myOwnFunc = (x, y) => (x > y);

            bool eredmeny = myOwnFunc(3, 4);

            Console.WriteLine(eredmeny);
        }
    }
}
