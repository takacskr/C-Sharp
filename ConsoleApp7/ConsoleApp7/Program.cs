using System.Diagnostics;

namespace ConsoleApp7
{
    class DisposableClass : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Cleaning...");
            GC.SuppressFinalize(this);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using (DisposableClass dc = new DisposableClass())
            {

            }

            //Console.ReadKey();
        }
    }
}
