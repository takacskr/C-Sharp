using System;
using System.Threading.Tasks;
namespace TestApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            Task task1 = Task.Factory.StartNew( () => Console.WriteLine("Én egy Task vagyok!") );

            Task task2 = Task.Factory.StartNew( () => Console.WriteLine("Én is egy Task vagyok!") );

            task2.Wait();

            Console.ReadKey();
        }
    }
}