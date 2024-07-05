namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 4, 4, 5, 6 };
            Console.WriteLine(uniqueNumbers.Contains(4)); // True
            Console.WriteLine(uniqueNumbers.Contains(7)); // False

            uniqueNumbers.Add(7);
            Console.WriteLine(uniqueNumbers.Contains(7)); // True

            uniqueNumbers.Remove(4);
            Console.WriteLine(uniqueNumbers.Contains(4)); // False
        }
    }
}
