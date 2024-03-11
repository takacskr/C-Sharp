using System;
using System.Threading.Tasks;
namespace TestApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            Task<int> task = new Task<int>(
            () => { return 10; }
            );

            task.Start();
            
            Console.WriteLine(task.Result); // 10
            
            Console.ReadKey();
        }
    }
}