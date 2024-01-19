using System;

namespace ConsoleApp1
{
    // Külső osztály definíciója
    class Outer
    {
        // Privát adattag: 'value'
        private int value = 11;

        // Privát belső osztály: 'Inner'
        private Inner child;

        // Külső osztály konstruktora
        public Outer()
        {
            // Inicializáljuk a 'child' változót egy új 'Inner' objektummal, és átadjuk neki az aktuális 'Outer' objektumot ('this')
            child = new Inner(this);
        }

        // Metódus a külső osztályban
        public void Do()
        {
            // Hívjuk meg a belső osztály 'Do' metódusát
            child.Do();
        }

        // Belső osztály definíciója
        class Inner
        {
            // Privát változó a külső osztályra való hivatkozáshoz
            Outer parent;

            // Belső osztály konstruktora, kap egy 'Outer' objektumot és eltárolja azt a 'parent' változóban
            public Inner(Outer parent)
            {
                this.parent = parent;
            }

            // Metódus a belső osztályban, kiírja a külső osztály 'value' adattagját a konzolra
            public void Do()
            {
                Console.WriteLine(parent.value);
            }
        }
    }

    // Főprogram
    class Program
    {
        static void Main(string[] args)
        {
            // Létrehozunk egy új 'Outer' objektumot
            Outer outerInstance = new Outer();

            // Hívjuk meg a külső osztály 'Do' metódusát
            outerInstance.Do();
        }
    }
}
