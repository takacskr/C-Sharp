class Test
{
    private Mutex mutex = new Mutex();
    public void ResourceMetod()
    {
        mutex.WaitOne();

        Console.WriteLine("{0} használja az erõforrást...", Thread.CurrentThread.Name);
        Thread.Sleep(1000);
        
        mutex.ReleaseMutex();
        
        Console.WriteLine("{0} elengedi az erõforrást...", Thread.CurrentThread.Name);
    }
}
class Program
{
    static Test t = new Test();
static public void ResourceUserMethod()
    {
        for (int i = 0; i < 10; ++i)
        {
            t.ResourceMetod();
        }
    }
    static void Main()
    {
        List<Thread> threadList = new List<Thread>();
        for (int i = 0; i < 10; ++i)
        {
            threadList.Add(
            new Thread(new ThreadStart(Program.ResourceUserMethod))
            {
                Name = "Thread" + i.ToString()
            });
        }
        threadList.ForEach((thread) => thread.Start());
    }
}