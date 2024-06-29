namespace StringReverse
{
    public static class StringExtension
    {
        public static string Reverse(this string str)
        {
            int length = str.Length;
            char[] reverse = new char[length];

            for (int i = 0; i < length; i++)
            {
                reverse[i] = str[(length -1) - i];
            }

            return new string(reverse);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "World";
            Console.WriteLine(str.Reverse());
        }
    }
}
