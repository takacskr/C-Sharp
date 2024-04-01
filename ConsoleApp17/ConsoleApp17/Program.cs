using System;

class Book
{
    private int _year;

    public int Year
    {
        get { return CalculateYearsAgo(_year); }
        set { _year = value; }
    }

    public int Isbn { get; set; }

    public string Title { get; set; }

    public Book(int isbn, int year, string title)
    {
        Isbn = isbn;
        Year = year;
        Title = title;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"ISBN: {Isbn}, Year: {Year}, Title: {Title}");
    }

    private int CalculateYearsAgo(int publicationYear)
    {
        return DateTime.Now.Year - publicationYear;
    }
}

class AnotherBook : Book
{
    /*
     * Az AnotherBook osztály konstruktora a base kulcsszóval hívja meg az ősosztály,
     * azaz a Book osztály konstruktorát. A base(isbn, year, title) részletesen megadja
     * az isbn, year és title paramétereket az ősosztály konstruktorának meghívásakor.
     * 
     *  a : base() rész a Book osztály konstruktorának meghívását jelenti az adott paraméterekkel.
     *  Ezáltal az AnotherBook konstruktora azonosítja az isbn, year és title adattagokat
     *  az ősosztályban, és inicializálja azokat a megadott értékekkel.
     */
    public AnotherBook(int isbn, int year, string title) : base(isbn, year, title)
    {
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Book book = new Book(1234, 1986, "Chernobyl");
        book.DisplayBookInfo();

        AnotherBook aBook = new AnotherBook(5678, 1976, "The C Programming Language");
        aBook.DisplayBookInfo();
    }
}
