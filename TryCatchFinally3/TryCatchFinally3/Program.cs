namespace TryCatchFinally3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            try
            {
                Console.WriteLine("x értéke a kivétel előtt. {0}", x);
            }
            catch (Exception)
            {
                Console.WriteLine("Kivétel. Hurrá!");
            }
            finally
            {
                Console.WriteLine("Finally blokk");
                x = 11;
            }

            Console.WriteLine("x értéke a kivétel után {0}", x);

            Console.ReadKey();
        }
    }
}
