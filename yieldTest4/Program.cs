namespace yieldTest4
{
    public static class Numbers
    {
        public static IEnumerable<int> GetNumbers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                yield return i;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var number in Numbers.GetNumbers(10))
            {
                Console.Write(number);
            }
        }
    }
}
