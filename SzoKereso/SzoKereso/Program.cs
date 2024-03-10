using System;
using System.Threading.Tasks;
using System.Net;
using System.Linq;
namespace TestApp
{
    class Program
    {
        static public void Main(string[] args)
        {
            WebClient wc = new WebClient();

            string[] s = wc.DownloadString(
            "https://www.gutenberg.org/cache/epub/103/pg103.txt")
            .Split(
            new char[] { ' ', '\u000A', ',', '.', ';', ':', '-', '_', '/' },
            StringSplitOptions.RemoveEmptyEntries
            );

            Parallel.Invoke(
            () => Console.WriteLine(
            s.OrderByDescending((item) => item.Length).First()),
            () => Console.WriteLine(s.Length)
            );

            Console.ReadKey();
        }
    }
}