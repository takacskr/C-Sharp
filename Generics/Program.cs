using System;
using System.Collections.Generic;

// Define a Book class
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

// Define a DVD class
public class DVD
{
    public string Title { get; set; }
    public string Director { get; set; }
}

// Define a generic MediaContainer class
public class MediaContainer<T>
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public T GetItem(int index)
    {
        return _items[index];
    }

    public int Count
    {
        get { return _items.Count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a container for books
        MediaContainer<Book> bookContainer = new MediaContainer<Book>();
        bookContainer.AddItem(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee" });
        bookContainer.AddItem(new Book { Title = "1984", Author = "George Orwell" });

        Console.WriteLine("Books:");
        for (int i = 0; i < bookContainer.Count; i++)
        {
            Book book = bookContainer.GetItem(i);
            Console.WriteLine($"  {book.Title} by {book.Author}");
        }

        // Create a container for DVDs
        MediaContainer<DVD> dvdContainer = new MediaContainer<DVD>();
        dvdContainer.AddItem(new DVD { Title = "The Shawshank Redemption", Director = "Frank Darabont" });
        dvdContainer.AddItem(new DVD { Title = "The Godfather", Director = "Francis Ford Coppola" });

        Console.WriteLine("DVDs:");
        for (int i = 0; i < dvdContainer.Count; i++)
        {
            DVD dvd = dvdContainer.GetItem(i);
            Console.WriteLine($"  {dvd.Title} by {dvd.Director}");
        }
    }
}