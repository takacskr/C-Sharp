namespace ArrayCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] sheeps = { true, false, true, true };
            Console.WriteLine(sheeps.Count(s => s));

            int[] n = { 10, 23, 83, 55, 68, 75, 32 };
            Console.WriteLine(n.Average());
            Console.WriteLine(n.Count());
        }
    }
}
