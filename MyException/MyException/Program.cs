namespace MyException
{
    class MyException : System.Exception
    {
        public MyException() { }

        public MyException(string message)
            : base(message) { }

        public MyException(string message, Exception inner)
            : base (message, inner) { }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new MyException("Kivétel. Hurrá!");
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
