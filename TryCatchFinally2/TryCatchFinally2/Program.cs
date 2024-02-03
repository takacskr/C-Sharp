namespace TryCatchFinally2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = new int[2];
                array[3] = 10;
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("OutOfRange");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Exception");
            }

            Console.ReadKey();
        }
    }
}
