using System;

public class Dog
{
    private string _name;
    private int _age;

    public Dog(string name, int age)
    {
        this._name = name;
        this._age = age;
    }

    public Dog(Dog OtherDog)
        : this(OtherDog._name, OtherDog._age)
    { }

    public void Bark()
    {
        Console.WriteLine("Vau vau");
    }

    public string Name
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


    }

}