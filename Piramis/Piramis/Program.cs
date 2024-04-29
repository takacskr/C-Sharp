namespace Piramis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 8; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (j == 1) Console.Write($"{i} ");
                    else Console.Write($"{j * i} ");
                }

                Console.WriteLine();
            }
        }
    }
}
