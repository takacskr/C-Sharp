using System;

namespace TestApp
{
    class Program
    {
        enum Animal : byte {Cat, Dog, Tiger, Wolf};

        static void Main(string[] args)
        {
            Animal b = Animal.Tiger;

            if (b == Animal.Tiger)
            {
                Console.WriteLine("B is a tiger");
            }

            if (Animal.Cat == 0)
            {
                Console.WriteLine($"Animal is a cat");
            } else
            {
                Console.WriteLine($"Animal is NOT a cat");
            }

            Console.WriteLine($"Amimal Cat is: {(int)Animal.Cat}");

            Animal a = Animal.Cat;
            int x = (int)a;
            Console.WriteLine(x);

            a = Animal.Wolf;
            x = (int)a;
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}