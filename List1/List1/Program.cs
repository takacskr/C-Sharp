using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace List1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 13, 72, 48, 55, 69 };
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = rnd.Next(100);

                if (!list.Contains(randomNumber))
                {
                    list.Add(i + rnd.Next(100));
                }
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"The last even number in the list:" +
                $"{list.FindLast( (x) => (x % 2) == 0)}");

            
            list.ForEach(x =>
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine($"This is an even number: {x}");
                }
            });

            Console.WriteLine("Even numbers in the list:");

            foreach (var item in list.Where(x => x % 2 == 0))
            {
                Console.WriteLine(item);
            }

            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            evenNumbers.ForEach(x => Console.WriteLine($"Even numbers: {x}"));

        }
    }
}
