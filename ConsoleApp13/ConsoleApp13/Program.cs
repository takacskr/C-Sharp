using System;

namespace ConsoleApp13
{
    // Külső (Outer) osztály
    class Outer
    {
        // Privát tagváltozó a külső osztályban
        private int value = 11;

        // Privát tagváltozó a belső (Inner) osztályra mutató referenciával
        private Inner child;

        // Konstruktor, ahol inicializáljuk a belső osztályt
        public Outer()
        {
            // Létrehozunk egy belső osztály példányt és hozzárendeljük a child változóhoz
            // A child változóra mutató referenciát elmenti az Outer osztály példányában
            child = new Inner(this);
        }

        // Metódus, ami meghívja a belső osztály metódusát
        public void Do()
        {
            child.Do();
        }

        // Belső (Inner) osztály
        class Inner
        {
            // Referencia a külső osztályra
            Outer parent;

            // Belső osztály konstruktora, amely kap egy külső osztály példányt
            public Inner(Outer obj)
            {
                // A külső osztályra mutató referenciát eltároljuk
                parent = obj;
            }

            // Belső osztály metódusa
            public void Do()
            {
                // Elérjük és kiírjuk a külső osztály privát tagváltozóját
                Console.WriteLine(parent.value);
            }

            // Statikus Main metódus, mely csak belső osztályon belül hívható meg
            static void Main()
            {
                Outer outer = new Outer();
                outer.Do();
            }
        }
    }
}
