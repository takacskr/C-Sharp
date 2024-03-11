using System;
using System.Threading.Tasks;
namespace TestApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            string[] array = new string[]
            {
                "Én egy Task vagyok!",
                "Én is egy Task vagyok!",
                "Én nem vagyok egy Task!"
            };

            foreach (string item in array)
            {
                Task task = new Task(
                (obj) => Console.WriteLine(obj),
                item);
                task.Start();
            }

            Console.ReadKey();
        }
    }
}