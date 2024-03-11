using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Process[] processList = Process.GetProcesses(".");

        foreach (Process process in processList)
        {
            Console.WriteLine($"PID: {process.Id}, Process  név: {process.ProcessName}");

            ProcessThreadCollection ptc = process.Threads;

            foreach (ProcessThread thread in ptc)
            {
                Console.WriteLine($"Id: {thread.Id}, Állapot: {thread.ThreadState}");
            }
        }
    }
}