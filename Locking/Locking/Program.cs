using System;
using System.Threading;

class Test
{
    static int x = 10;
    static int y = 20;

    static object locker = new object();
    static public void Divide()
    {
        lock (locker)
        {
            if (Test.x != 0)
            {
                Thread.Sleep(2);
                Console.WriteLine(Test.y / Test.x);
                Test.x = 0;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(new ThreadStart(Test.Divide));
        Thread t2 = new Thread(new ThreadStart(Test.Divide));
        t1.Start();
        t2.Start();
    }
}