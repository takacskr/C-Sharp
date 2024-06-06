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

    public Dog(string name = "", int age = 0)
    {
        this._name = name;
        this._age = age;
    }

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
        Dog d = new Dog() { Name = "Füli", Age = 5 };
        Dog e = new Dog(d);

        // A tulajdonságot kiírjuk
        Console.WriteLine(e.FormattedData);
    }
}

/*
 * A másoló konstruktor (copy constructor) szerepe a C# programozási nyelvben az,
 * hogy egy már létező objektum másolatát hozza létre, az objektum állapotának pontos másolatát megőrizve.
 * Ez azt jelenti, hogy a másoló konstruktor egy új objektumot hoz létre, amely az eredeti objektum
 * minden tulajdonságát és értékét másolja, így az új objektum teljesen azonos lesz az eredetivel.

 * A másoló konstruktor használatával elkerülhető, hogy az objektumok referencia szerinti másolása során
 * az eredeti objektumot módosítsuk, ami akár váratlan eredményekhez is vezethet.
 * Ehelyett a másoló konstruktor garantálja, hogy az új objektum független lesz az eredetitől,
 * és a módosítások nem érintik az eredeti objektumot.
 * 
 * Ez a másoló konstruktor egy "Dog" objektumot vár paraméterként,
 * majd ebből a másik Dog objektumból inicializálja az aktuális objektumot.
 * Ez azt jelenti, hogy a másik "Dog" objektum tulajdonságait átmásoljuk az aktuális objektumba.
 * */