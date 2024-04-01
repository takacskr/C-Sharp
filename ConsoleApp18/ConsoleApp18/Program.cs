using System;

class Dog
{
    private string _name = "";
    private int _age = 0;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public Dog(string name = "Füli", int age = 2)
    {
        this._name = name;
        this._age = age;
    }

    /* Ez a másoló konstruktor egy "Dog" objektumot vár paraméterként,
     * majd ebből a másik Dog objektumból inicializálja az aktuális objektumot.
     * Ez azt jelenti, hogy a másik "Dog" objektum tulajdonságait átmásoljuk az aktuális objektumba.
     * */
    public Dog(Dog otherDog) : this(otherDog._name, otherDog._age) { }

    // Új tulajdonság, amely visszaadja a formázott adatokat
    public string FormattedData
    {
        get { return $"Name: {Name}, Age: {Age}"; }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        Dog e = new Dog(d);

        // A tulajdonságot kiírjuk
        Console.WriteLine(e.FormattedData);
    }
}
