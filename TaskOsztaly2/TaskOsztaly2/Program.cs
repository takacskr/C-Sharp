using System;
using System.Threading.Tasks;
namespace TestApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            Task task = new Task(
            () => Console.WriteLine("Én egy Task vagyok!")
            );

            task.Start();
            task.Wait();
            
            Console.ReadKey();
        }
    }
}