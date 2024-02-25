using System;
using System.Diagnostics; // erre a névtérre szükség van
class Program
{
    static void Main(string[] args)
    {
        Process[] processList = Process.GetProcesses(".");
        foreach (Process process in processList)
        {
            Console.WriteLine("A folyamat ({0}) szálai",
            process.ProcessName);
            ProcessThreadCollection ptc = process.Threads;
            foreach (ProcessThread thread in ptc)
            {
                Console.WriteLine("Id: {0}, Állapot: {1}",
                thread.Id, thread.ThreadState);
            }
        }
        Console.ReadKey();
    }
}