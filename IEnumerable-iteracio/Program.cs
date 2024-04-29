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

class Program
{
    private static List<Person> people = new List<Person>();

    static void Main()
    {
        people.Add(new Person("Alice", 30));
        people.Add(new Person("Bob", 25));
        people.Add(new Person("Charlie", 35));

        // Iterálás a PeopleCollection példányon
        foreach (Person person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
