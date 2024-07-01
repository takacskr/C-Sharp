using System.Collections.Generic;

public class NewsletterSignup
{
    public readonly HashSet<string> _uniqueEmailAddresses;

    public NewsletterSignup()
    {
        _uniqueEmailAddresses = new HashSet<string>();
    }

    public bool IsValidEmail(string email)
    {
        return !_uniqueEmailAddresses.Contains(email);
    }

    public void AddEmail(string email)
    {
        if (IsValidEmail(email))
        {
            _uniqueEmailAddresses.Add(email);
            Console.WriteLine($"Added {email} to the newsletter list.");
        }
        else
        {
            Console.WriteLine($"Email {email} is already in use.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        NewsletterSignup newsletter = new NewsletterSignup();

        newsletter.AddEmail("john.doe@example.com");
        newsletter.AddEmail("jane.doe@example.com");
        newsletter.AddEmail("john.doe@example.com"); // duplicate email

        Console.WriteLine("Unique email addresses:");
        foreach (string email in newsletter._uniqueEmailAddresses)
        {
            Console.WriteLine(email);
        }
    }
}

/*
    In this example, we have a NewsletterSignup class that uses a HashSet<string> to store unique email addresses.
    The IsValidEmail method checks if an email address is already in the set, and the AddEmail method adds a
    new email address to the set if it's not already in use.

    When we run the program, we get the following output:

    Added john.doe@example.com to the newsletter list.
    Added jane.doe@example.com to the newsletter list.
    Email john.doe@example.com is already in use.
    Unique email addresses:
    john.doe@example.com
    jane.doe@example.com
    As you can see, the HashSet<string> ensures that we don't add duplicate email addresses to the list,
    and we can quickly validate if an email address is already in use.

    This example demonstrates how a HashSet<T> can be used to enforce uniqueness and provide
    fast lookup operations in a real-world scenario.
*/