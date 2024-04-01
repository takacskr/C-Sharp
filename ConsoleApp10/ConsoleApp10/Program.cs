using System;

/*
  Amikor létrehozunk egy Dog objektumot ezzel a konstruktorral,
akkor először a Dog(string name) konstruktor fog meghívódni,
amely beállítja a _name adattagot a kapott névre.

Ezután a Dog(string name, int age) konstruktor beállítja a _age adattagot a kapott korra.

Ez az osztály lehetővé teszi a kódnak, hogy különböző módokon hozzon létre Dog objektumokat.
Ha csak a névét ismerjük, akkor csak az első konstruktort kell használnunk, de ha a korát
is ismerjük, akkor használhatjuk a második konstruktort, és csak meg kell adnunk mind a névét, mind a korát.

Az objektum inicializálása során a konstruktorokat hívjuk meg, 
míg a property-k a létrehozott objektumon belül az adatmezőkhöz vezető elérési pontokként működnek.
 */

namespace ConsoleApp10
{
    class Dog
    {
        private string _name;
        private int _age;

        public Dog(string name)
        {
            _name = name;
        }

        public Dog(string name, int age) : this(name)
        {
            _age = age;
        }

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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Füli");
            Dog dog2 = new Dog("Morzsi", 7);

            Console.WriteLine(dog.Name);
            Console.WriteLine($"{ dog2.Name}, {dog2.Age}");
        }
    }
}
