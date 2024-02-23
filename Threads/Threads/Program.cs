using System;
using System.Threading;
class Test
{
    public void ThreadInfo()
    {
        Console.WriteLine("Szál-név: {0}", Thread.CurrentThread.Name);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Test t = new Test();
        Thread backgroundThread = new Thread( new ThreadStart(t.ThreadInfo) );
        backgroundThread.Name = "Background-Thread";
        backgroundThread.Start();
    }
}