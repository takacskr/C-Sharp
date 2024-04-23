using System;
using System.Collections;
using System.Collections.Generic;

/*
 * Ez a program egy egyszerű példa arra, hogyan iterálhatunk osztály példányai között.
 * Ehhez implementálnunk kell az 'IEnumerable' vagy az 'IEnumerable<T>' interfészt.
 * Ekkor lehetséges a foreach ciklussal iterálni osztálypéldányok között.
 * 
 * Az IEnumerable interfész implementálása lehetővé teszi a PeopleCollection
 * objektumokon való iterációt a foreach ciklussal.
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

class PeopleCollection : IEnumerable
{
    private List<Person> people = new List<Person>();

    public void AddPerson(Person person)
    {
        people.Add(person);
    }

    public IEnumerator GetEnumerator()
    {
        return people.GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        PeopleCollection collection = new PeopleCollection();
        collection.AddPerson(new Person("Alice", 30));
        collection.AddPerson(new Person("Bob", 25));
        collection.AddPerson(new Person("Charlie", 35));

        // Iterálás a PeopleCollection példányon
        foreach (Person person in collection)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
