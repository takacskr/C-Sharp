namespace ConsoleApp9
{
    class NewString1
    {
        private string aString;

        public NewString1(string s)
        {
            this.aString = s;
        }

        public void PrintUpper()
        {
            Console.WriteLine(this.aString.ToUpper());
        }
    }

    class NewString2
    {
        public void PrintUpper(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NewString1 ns1 = new NewString1 ("baba");
            NewString2 ns2 = new NewString2();

            ns1.PrintUpper();
            ns2.PrintUpper("baba");

            Console.ReadKey();
        }
    }
}
