namespace ConsoleApp28
{
    class Book
    {
        public static int BookCounter = 0;

        public Book()
        {
            ++BookCounter;
        }

        ~Book()
        {
            --BookCounter;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new();
            Book book2 = new();
            Book book3 = new();
            Console.WriteLine(Book.BookCounter);
        }
    }
}
