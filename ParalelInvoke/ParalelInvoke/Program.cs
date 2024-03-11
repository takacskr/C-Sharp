using System;
using System.Threading.Tasks;
using System.Net;
namespace TestApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            Parallel.Invoke(
            () => Console.WriteLine("Task 1"),
            () => Console.WriteLine("Task 2"),
            () => Console.WriteLine("Task 3")
            );

            Console.ReadKey();
        }
    }
}