namespace Filekezeles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            using (StreamReader reader = File.OpenText("numbers.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) is not null)
                {
                    if (int.TryParse(line, out int number))
                    {
                        numbers.Add(number);
                    }
                }

                reader.Close();
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
