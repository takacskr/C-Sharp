namespace yieldTest5
{
    public static class Numbers
    {
        public static IEnumerable<int> GetNumbers(params IEnumerable<int>[] arrays)
        {
            foreach (var array in arrays)
            {
                foreach (var number in array)
                {
                    yield return number;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = new[] { 1, 2, 3 };
            var array2 = new[] { 4, 5, 6 };
            var arrays = new[] { array1, array2 };

            var numbers = Numbers.GetNumbers(arrays);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
