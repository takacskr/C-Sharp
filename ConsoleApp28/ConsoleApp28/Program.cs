namespace ConsoleApp28
{
    class Book
    {
        public static int BookCounter = 0;

        public Book()
        {
            ++BookCounter;
        }


        // A finalizer egy speciális függvény a C#-ban, amelyet a .NET Garbage Collector hív meg,
        // amikor egy objektumot megsemmisít a memóriában. A finalizer segítségével az objektum
        // tisztítást végezhet, például lezárhat fájlokat, zárolhat forrásokat vagy
        // visszafordíthat változásokat.
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
