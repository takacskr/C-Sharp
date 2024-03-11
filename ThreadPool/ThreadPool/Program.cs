using System;
using System.Threading;
class Program
{
    static public void Do(object inObj)
    {
        Console.WriteLine("A következõ adatot használjuk: {0}",
        (int)inObj);
        Thread.Sleep(500);
    }
    static void Main(string[] args)
    {
        ThreadPool.SetMaxThreads(5, 0);
        for (int i = 0; i < 20; ++i)
        {
            ThreadPool.QueueUserWorkItem(
            new WaitCallback(Program.Do),
            i);
        }
        Console.ReadKey();
    }
}