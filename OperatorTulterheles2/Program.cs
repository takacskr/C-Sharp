using System;

class Money
{
    public decimal Amount { get; set; }

    public Money(decimal amount)
    {
        Amount = amount;
    }

    // Összeadás operátor túlterhelése
    public static Money operator +(Money m1, Money m2)
    {
        return new Money(m1.Amount + m2.Amount);
    }

    // Kivonás operátor túlterhelése
    public static Money operator -(Money m1, Money m2)
    {
        return new Money(m1.Amount - m2.Amount);
    }

    // Egyenlőség operátor túlterhelése
    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Amount == m2.Amount;
    }

    public static bool operator !=(Money m1, Money m2)
    {
        return !(m1 == m2);
    }

    // Nagyobb vagy egyenlő operátor túlterhelése
    public static bool operator >=(Money m1, Money m2)
    {
        return m1.Amount >= m2.Amount;
    }

    // Kisebb vagy egyenlő operátor túlterhelése
    public static bool operator <=(Money m1, Money m2)
    {
        return m1.Amount <= m2.Amount;
    }

    // ToString metódus túlterhelése
    public override string ToString()
    {
        return $"{Amount:C}"; // Formázott pénzösszeg
    }
}

class Program
{
    static void Main(string[] args)
    {
        Money salary = new Money(1500);
        Money expenses = new Money(800);

        // Összeadás operátor használata
        Money totalIncome = salary + expenses;
        Console.WriteLine("Total income: " + totalIncome);

        // Kivonás operátor használata
        Money savings = salary - expenses;
        Console.WriteLine("Savings: " + savings);

        // Egyenlőség operátor használata
        Console.WriteLine("Are they equal? " + (salary == expenses));

        // Nagyobb vagy egyenlő operátor használata
        Console.WriteLine("Is salary greater than or equal to expenses? " + (salary >= expenses));

        // Kisebb vagy egyenlő operátor használata
        Console.WriteLine("Is salary less than or equal to expenses? " + (salary <= expenses));
    }
}
