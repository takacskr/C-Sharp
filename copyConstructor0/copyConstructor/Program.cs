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

}

public class Program
{
    public static void Main()
    {
        Dog d = new Dog("Füli", 5);
        Dog o = new Dog(d);
    }
}