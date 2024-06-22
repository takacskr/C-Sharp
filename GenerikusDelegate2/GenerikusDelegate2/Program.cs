using System;

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
    delegate void Method<in T>(T t);
    static void Main(string[] args)
    {
        Method<Person> m1 = (person) => Console.WriteLine(person.Age);
        Method<Student> m2 = m1;
        Student s = new Student()
        {
            Age = 22,
            Name = "Szandra"
        };
        m1(s); // 22
        m2(s); // 22
        Console.ReadKey();
    }
}