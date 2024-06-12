using System;

public class Dog
{
    private string? _name;
    private int _age;

    public Dog(string name, int age)
    {
        if (name == null)
        {
            throw new ArgumentNullException(nameof(name), "Name cannot be null.");
        }

        Name = name;
        Age = age;
    }

    public Dog(Dog OtherDog)
    {
        if (OtherDog is null)
        {
            throw new ArgumentNullException(nameof(OtherDog), "OtherDog cannot be bull");
        }

        if (OtherDog.Name is null)
        {
            throw new ArgumentNullException(nameof(OtherDog.Name), "OtherDog.Name cannot be bull");
        }

        this.Name = OtherDog.Name;
        this.Age = OtherDog.Age;
    }

    public void Bark()
    {
        Console.WriteLine("Vau vau");
    }

    public string? Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(Name), "Name cannot be null or empty.");
            }
            _name = value;
        }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(Age), "Age cannot be negative.");
            }
            _age = value;
        }
    }

    // ... constructors and other methods
}


public class Program
{
    public static void Main()
    {
        Dog d = new Dog("Fido", 3);
        Console.WriteLine($"Dog's name: {d.Name}, Age: {d.Age}");
        d.Bark(); // Assuming you added a Bark() method

        Dog o = new Dog(d);
        o.Name = "Sunny";
        o.Age = 7;

        Console.WriteLine($"Dog's name: {d.Name}, Age: {d.Age}");
    }

}