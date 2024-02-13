﻿namespace List4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1, 1001));
            }

            Console.WriteLine("The first even number in the list: {0}",
                list.Find(x => x % 2 == 0));

            // Az anonim függvényt közvetlenül adjuk át a FindAll metódusnak paraméterként,
            // így a FindAll metódus tudja, hogy milyen feltétellel kell kiválogatni az elemeket a listából.
            List<int> evenList = list.FindAll(delegate (int item)
            {
                return item % 2 == 0;
            });

            Console.WriteLine("All even number in the list: ");

            evenList.ForEach(delegate (int item)
            {
                Console.WriteLine(item);
            });
        }
    }
}
