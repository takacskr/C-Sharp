using System;

class Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Összeadás operátor túlterhelése
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Kivonás operátor túlterhelése
    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    // Egyenlőség operátor túlterhelése
    public static bool operator ==(Complex c1, Complex c2)
    {
        return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
    }

    public static bool operator !=(Complex c1, Complex c2)
    {
        return !(c1 == c2);
    }

    // ToString metódus túlírása az osztályban
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex c1 = new Complex(1, 2);
        Complex c2 = new Complex(3, 4);

        // Használjuk az összeadás operátort
        Complex sum = c1 + c2;
        Console.WriteLine("Sum: " + sum);

        // Használjuk a kivonás operátort
        Complex difference = c1 - c2;
        Console.WriteLine("Difference: " + difference);

        // Használjuk az egyenlőség operátort
        Console.WriteLine("Are they equal? " + (c1 == c2));
    }
}
