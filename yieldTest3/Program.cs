namespace yieldTest3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> GetNumbers()
            {
                Console.WriteLine("Kezdés");
                yield return 1;
                Console.WriteLine("1 után");
                yield return 2;
                Console.WriteLine("2 után");
                yield return 3;
                Console.WriteLine("3 után");
                yield break;
                Console.WriteLine("Vég");
            }

            foreach (int number in GetNumbers())
            {
                Console.WriteLine(number);
            }
        }
    }
}
