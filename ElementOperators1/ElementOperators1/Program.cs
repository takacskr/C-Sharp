namespace ElementOperators1
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = new List<int>()
            {
                10, 3, 56, 67, 4, 6, 78, 44
            };

            var result1 = list.First(); // 10
            var result2 = list.Last(); // 44

            var result3 = list.First( (item) => item > 10); // 56

            try
            {
                var result4 = list.Last( (item) => item < 3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var result5 = list.FirstOrDefault( (item) => item < 3);

            Console.WriteLine($"{result1}, {result2}, {result3}, {result5}");

            Console.ReadKey();
        }
    }
}
