using System.Threading.Channels;

namespace Lambda_Action1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int> act = (x) => Console.WriteLine(x);
            act(1);
        }
    }
}
