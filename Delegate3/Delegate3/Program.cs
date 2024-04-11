using System;

namespace TestApp
{
    // Animal osztály definiálása
    class Animal { }

    // Dog osztály, ami Animal osztályból származik
    class Dog : Animal { }

    // Cat osztály, ami Animal osztályból származik
    class Cat : Animal { }

    class Program
    {
        // GetAnimal delegátum definiálása, ami Animal típusú objektumot ad vissza
        public delegate Animal GetAnimal();

        // AnimalMethod metódus definiálása, ami egy Animal típusú objektumot hoz létre és visszaadja
        static public Animal AnimalMethod() { return new Animal(); }

        // DogMethod metódus definiálása, ami egy Dog típusú objektumot hoz létre és visszaadja
        static public Dog DogMethod() { return new Dog(); }

        // CatMethod metódus definiálása, ami egy Cat típusú objektumot hoz létre és visszaadja
        static public Cat CatMethod() { return new Cat(); }

        static void Main()
        {
            // GetAnimal delegátum példányosítása és AnimalMethod metódusra állítása
            // Itt létrehozunk egy GetAnimal típusú delegátum példányt AnimalMethod metódus referenciájával
            GetAnimal ga = AnimalMethod;

            // ga delegátum meghívása és az eredmény elmentése az 'a' változóban:
            // Ez meghívja a ga delegátumot, ami valójában a AnimalMethod-ra mutat,
            // és elmenti az eredményt az a változóban
            Animal a = ga();

            // ga delegátum átállítása DogMethod metódusra
            // Most megváltoztatjuk a ga delegátumot, hogy a DogMethod-ra mutasson
            ga = DogMethod;

            // ga delegátum meghívása és az eredmény elmentése a 'd' változóban
            // Az(Dog) kifejezés explicit kasztolást jelent, és az Animal típusú objektumot
            // próbálja Dog típusúvá alakítani.Ezért ez az explicit kasztolás azt jelenti,
            // hogy az Animal objektumot Dog objektummá próbáljuk konvertálni
            // Tehát meghívjuk a ga delegátumot, ami most a DogMethod-ra mutat,
            // majd a visszatérési értéket típusként Dog-ra kasztoljuk és elmentjük az d változóban
            Dog d = (Dog)ga();

            // ga delegátum átállítása CatMethod metódusra
            // Hasonlóan megváltoztatjuk a ga delegátumot, hogy most már a CatMethod-ra mutasson
            ga = CatMethod;

            // ga delegátum meghívása és az eredmény elmentése a 'c' változóban
            // Újra meghívjuk a ga delegátumot, ami most a CatMethod-ra mutat,
            // majd a visszatérési értéket típusként Cat-ra kasztoljuk és elmentjük a c változóban
            Cat c = (Cat)ga();

            // Az 'a', 'd' és 'c' változók típusainak kiírása a konzolra
            Console.WriteLine("{0}, {1}, {2}", a.GetType(), d.GetType(), c.GetType());
            // Eredmény: TestApp.Animal, TestApp.Dog, TestApp.Cat

            // Gombnyomásra várakozás, mielőtt a program befejeződik
            Console.ReadKey();
        }
    }
}
