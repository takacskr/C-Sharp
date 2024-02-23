using System;
using System.Diagnostics;
using System.Threading; // erre a névtérre szükség van
class Program
{
    static void Main(string[] args)
    {
        Process explorer = Process.Start("explorer.exe");
        Thread.Sleep(5000);
        explorer.Kill();
        Console.ReadKey();
    }
}