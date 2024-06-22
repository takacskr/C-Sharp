using System;
using System.Collections.Generic;

public class Person
{
    public int Age;
}

public class Student : Person
{
    public string Name { get; set; }
}

public class Program
{
    delegate void Method<out T>();
    public static void Main()
    {
        List<Student> studentList = new List<Student>();
        List<Person> personList = new List<Person>();
        Method<Student> m1 = () => new Student();
        Method<Person> m2 = m1;
        IEnumerable<Student> sie = new List<Student>()
        {
            new Student()
            {
                Name = "Szandra",
                Age = 22
            },
            new Student()
            {
                Name = "István",
                Age = 26
            },
            new Student()
            {
                Name = "Béa",
                Age = 56
            },
        };
        IEnumerable<Person> pie = sie;
        foreach (Student student in pie)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        Student s = new Student()
        {
            Age = 22,
            Name = "Szandra"
        };

        Console.ReadKey();
    }
}