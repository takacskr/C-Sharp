using System;

namespace CSharpBase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            int[] array = new int[10];

            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            Console.WriteLine("Items of the Array:");

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            // List
            List<int> list = new List<int>()
            {
                28, 39, 44, 56, 98, 10, 38
            };

            list.Add(77);
            list.Add(33);

            Console.WriteLine("Items of the List:");

            list.ForEach(x => Console.WriteLine(x));
        }
    }
}


