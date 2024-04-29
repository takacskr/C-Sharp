using System;
using System.Collections;
using System.Collections.Generic;

/*
 * Ebben a példában az IEnumerable<T> interfészt használjuk a generikus PeopleCollection<T> osztályban,
 * ami egy kollekciót tárol a megadott típusú elemekkel. A T típusparaméter lehetővé teszi,
 * hogy az osztály bármilyen típussal használható legyen, amely a Person osztálytól származik vagy azt implementálja.
 * A GetEnumerator metódus visszaad egy IEnumerator<T> objektumot az iterációhoz.
 * 
 * A Main metódusban létrehozunk egy PeopleCollection<Person> példányt, hozzáadunk néhány Person példányt a kollekcióhoz,
 * majd végigmegyünk rajtuk a foreach ciklussal, és kiírjuk a nevüket és életkorukat.
 */

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

// Ezen osztály példányai között szeretnénk majd iterálni
class PeopleCollection<T> : IEnumerable<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    /*
     * Az IEnumerable<T>-t a GetEnumerator() metódus megvalósításával hoztuk létre, de az IEnumerable interfész is szükséges,
     * a C# nyelv azt várja, hogy biztosítsuk az IEnumerable.GetEnumerator() metódust is.
     * Ebben az esetben ez a metódus csak egyszerűen visszatér a GetEnumerator() metódusunkkal.
     * 
     * Tehát, amikor valaki IEnumerable típusúvá castolja az IEnumerable<T>-t, ez a metódus fog meghívódni,
     * és a GetEnumerator() metódust fogja visszaadni, amely az IEnumerator<T> típusú elemeket iterálja végig.
     */
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        PeopleCollection<Person> collection = new PeopleCollection<Person>();

        collection.AddItem(new Person("Alice", 30));
        collection.AddItem(new Person("Bob", 25));
        collection.AddItem(new Person("Charlie", 35));

        // Iterálás a PeopleCollection példányokon
        foreach (Person person in collection)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
