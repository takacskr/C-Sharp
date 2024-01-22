using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string phoneNumber1 = "+36 (30) 345 678";
        string phoneNumber2 = "+36 (20) 123-456";

        string pattern = @"^\+\d{2} \(\d{2}\) \d{3} \d{3}$";

        if (Regex.IsMatch(phoneNumber1, pattern))
        {
            Console.WriteLine($"{phoneNumber1} - Helyes telefonszám formátum.");
        }
        else
        {
            Console.WriteLine($"{phoneNumber1} - Nem megfelelő telefonszám formátum.");
        }

        if (Regex.IsMatch(phoneNumber2, pattern))
        {
            Console.WriteLine($"{phoneNumber2} - Helyes telefonszám formátum.");
        }
        else
        {
            Console.WriteLine($"{phoneNumber2} - Nem megfelelő telefonszám formátum.");
        }
    }
}
