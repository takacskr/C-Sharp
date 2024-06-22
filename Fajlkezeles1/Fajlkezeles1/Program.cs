using System;
using System.IO;

namespace Fajlkezeles1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("test1.txt", FileMode.Open);

            using (StreamReader sr = new StreamReader(fs))
            {
                string s = sr.ReadLine();

                while (s != null)
                {
                    Console.WriteLine(s);
                    s = sr.ReadLine();
                }

                sr.Close();
                fs.Close();
            }

            Console.ReadKey();
        }
    }
}
