using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Concurrent;
using System.Threading;

class Program
{
    static public double[,] GenerateMatrix(int size)
    {
        double[,] matrix = new double[size, size];
        Random r = new Random();
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                matrix[i, j] = r.Next(1000, 100000);
            }
        }
        return matrix;
    }
    static void Main(string[] args)
    {
        int size = 1000;
        double[,] a = GenerateMatrix(size);
        double[,] b = GenerateMatrix(size);
        double[,] c = new double[size, size];
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < size; ++i)
        {
            for (int j = 0; j < size; ++j)
            {
                double v = 0;
                for (int k = 0; k < size; ++k)
                {
                    v += a[i, k] * b[k, j];
                }
                c[i, j] = v;
            }
        }
        sw.Stop();
        Console.WriteLine("A ciklus által felhasznált idő: {0} ms",
        sw.ElapsedMilliseconds);
        c = new double[size, size];
        sw.Reset();
        sw.Start();
        Parallel.For(0, size, (i) =>
        {
            for (int j = 0; j < size; ++j)
            {
                double v = 0;
                for (int k = 0; k < size; ++k)
                {
                v += a[i, k] * b[k, j];
                }
                c[i, j] = v;
            }
        });
        sw.Stop();
        Console.WriteLine("A ciklus által felhasznált idő: {0} ms",
        sw.ElapsedMilliseconds);
        Console.ReadKey();
    }
}
