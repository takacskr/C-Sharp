using System;

// A névtér, amelybe a program kódja van csomagolva
namespace ConsoleApp14
{
    // Person osztály definíciója
    class Person
    {
        // Paraméter nélküli konstruktor
        public Person() { }

        // Privát adattag a név tárolására
        private string _name;

        // Name tulajdonság definíciója
        public string Name
        {
            // Getter: A név lekérdezése
            get { return _name; }

            // Setter: A név beállítása
            set { _name = value; }
        }
    }

    // Program osztály definíciója (internal módosítóval, csak ebben a névtérben látható)
    internal class Program
    {
        // Main metódus, a program futási pontja
        static void Main(string[] args)
        {
            // Person osztály példányosítása és inicializálása
            Person person = new()
            {
                // A Name tulajdonság beállítása "István" értékre
                Name = "István"
            };

            // A konzolra kiírjuk a Person osztály Name tulajdonságát
            Console.WriteLine(person.Name);

            // Várunk egy billentyűleütést, mielőtt a program befejeződne
            Console.ReadKey();
        }
    }
}
