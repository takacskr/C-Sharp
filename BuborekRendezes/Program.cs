namespace BuborekRendezes
{
    class Numbers
    {
        public int[] Array { get; set; }

        public Numbers(int[] array)
        {
            Array = array;
        }

        public void Arrange(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 44, 69, 11, 9, 73, 84 };

            Numbers numbers = new Numbers(array);

            numbers.Arrange(array);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
