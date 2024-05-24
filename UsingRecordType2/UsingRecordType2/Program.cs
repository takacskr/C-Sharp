using System;

public record Author(string FirstName, string LastName);

public record Book(string Title, Author Author, int YearPublished, string Genre);

class Program
{
    static void Main()
    {
        // Create an author
        var author = new Author("George", "Orwell");

        // Create a book
        var book1 = new Book("1984", author, 1949, "Dystopian");

        // Print the book details
        Console.WriteLine($"Book: {book1.Title}, Author: {book1.Author.FirstName} {book1.Author.LastName}, Year: {book1.YearPublished}, Genre: {book1.Genre}");

        // Create another book with the same details
        var book2 = new Book("1984", author, 1949, "Dystopian");

        // Value equality
        Console.WriteLine(book1 == book2); // True

        // Immutability
        // book1.Title = "Animal Farm"; // Compilation error

        // Using with-expression to create a modified copy of the book
        var book3 = book1 with { Title = "Animal Farm", YearPublished = 1945 };
        Console.WriteLine($"Book: {book3.Title}, Author: {book3.Author.FirstName} {book3.Author.LastName}, Year: {book3.YearPublished}, Genre: {book3.Genre}");

        // Deconstruction
        var (title, bookAuthor, year, genre) = book1;
        Console.WriteLine($"Title: {title}, Author: {bookAuthor.FirstName} {bookAuthor.LastName}, Year: {year}, Genre: {genre}");

        // Deconstructing the nested author record
        var (authorFirstName, authorLastName) = book1.Author;
        Console.WriteLine($"Author: {authorFirstName} {authorLastName}");
    }
}
