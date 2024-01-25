using System;

class Book
{
    private int _year;
    public int Isbn { get; set; }

    public int Year
    {
        get { return CalculateYearsAgo(_year); }
        set { _year = value; }
    }

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
