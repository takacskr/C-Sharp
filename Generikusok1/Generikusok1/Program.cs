namespace Generikusok1
{
    internal class Program
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Program.Swap<int>(ref x, ref y);
            Console.WriteLine($"x == {x} és y == {y}");

            string s1 = "alma";
            string s2 = "dió";

            Program.Swap<string>(ref s1, ref s2);
            Console.WriteLine($"x == {s1} és y == {s2}");
        }
    }
}
