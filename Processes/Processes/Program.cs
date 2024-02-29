using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Process[] processList = Process.GetProcesses(".");
        foreach (Process process in processList)
        {
            Console.WriteLine("PID: {0}, Process - név: {1}",
            process.Id, process.ProcessName);
        }
        Console.ReadKey();
    }
}