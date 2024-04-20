using System;

namespace Lambda1
{
    internal class Program
    {
        public delegate int IntFunc(int x, int y);
        static void Main()
        {
            IntFunc func = (x, y) => (x * y);

            Console.WriteLine(func(8, 9));
        }
    }
}
