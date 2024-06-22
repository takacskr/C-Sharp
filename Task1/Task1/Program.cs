using System;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Task<int> task = new Task<int>(
            () => { return 10; }
        );

        task.Start();
        Console.WriteLine(task.Result);
    }
}