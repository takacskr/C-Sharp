using System;
using System.Collections.Generic;

public class Document
{
    private string _title;
    private List<string> _pages; // Consider using a read-only collection for immutability

    public Document(string title, List<string> pages)
    {
        _title = title;
        _pages = pages; // This creates a shallow copy, be cautious!
    }

    // Copy constructor with deep copy for the page list
    public Document(Document other)
    {
        _title = other._title;
        _pages = new List<string>(other._pages); // Deep copy the page list
    }

    public void AddPage(string content)
    {
        _pages.Add(content);
    }

    public override string ToString()
    {
        return $"Title: {_title}\nPages: ({_pages.Count})";
    }
}

public class Program
{
    public static void Main()
    {
        List<string> pages = new List<string>() { "Page 1", "Page 2", "Page 3" };
        Document doc1 = new Document("My Document", pages);

        Console.WriteLine("Original Document:");
        Console.WriteLine(doc1);

        // Shallow copy creates an issue - modifying the copy affects the original!
        Document doc2 = new Document(doc1);
        doc2.AddPage("New Page");

        Console.WriteLine("\nOriginal Document (modified through copy):");
        Console.WriteLine(doc1); // Now has 3 pages!

        // Deep copy in the copy constructor ensures independent data
        Document doc3 = new Document(doc2);
        doc3.AddPage("Another Page");

        Console.WriteLine("\nOriginal Document:");
        Console.WriteLine(doc1); // Still has 2 pages
        Console.WriteLine("\nDeep Copied Document:");
        Console.WriteLine(doc3); // Now has 4 pages (independent)
    }
}
