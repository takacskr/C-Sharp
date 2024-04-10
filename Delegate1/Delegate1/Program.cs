using System;

namespace Delegate1
{
    /*
    A Transformer delegátumot definiáljuk, amely egy ref int típusú paraméterrel rendelkezik és nincs visszatérési értéke.
    A TransformerMethod egy statikus metódus a Program osztályban, amely megváltoztatja az átadott int típusú paramétert
    önmagával szorzás révén. A TransformerMethod metódus referenciáját hozzárendeljük a Transformer delegátumhoz az
    array.Transform(Program.TransformerMethod); sorban a Main metódusban.

    Delegátum meghívása:
    A Transform metódus meghívásakor a TransformerMethod metódus referenciája (delegátum) kerül átadásra.
    A Transform metóduson belül a delegátumot hívjuk meg a tömb minden elemére a t(ref array[i]); sorban.
    Ezen a ponton a TransformerMethod metódus valóban lefut, és módosítja a tömb minden elemét a megfelelő transzformációval.
    
    Metódusok közvetlen hívása:
    A Main metódusban két ciklussal feltöltjük és kiírjuk a tömb elemeit.
    A Console.WriteLine(array[i]); sorban közvetlenül hívjuk meg a Console.WriteLine metódust a tömb elemeinek kiírásához.
    Összességében tehát a delegátumot egy statikus metódus referenciájával töltjük fel, majd ezt a delegátumot használjuk a tömb
    transzformálására. A metódusokat közvetlenül hívjuk meg a tömb elemeinek feltöltéséhez és kiírásához a Main metódusban.
     */

    // Az Array osztály definiálása
    class Array
    {
        // Delegate definíciója a transzformációkhoz

        public delegate void Transformer(ref int item);

        // Privát tömb az Array osztályban
        private int[] array;

        // Konstruktor, létrehozza az Array osztályt a megadott hosszúsággal
        public Array(int length)
        {
            Length = length;
            array = new int[Length];
        }

        // Hossz tulajdonság a tömbhöz
        public int Length { get; set; }

        // Indexelő tulajdonság az Array osztályban
        // Az Array osztálynak van egy indexelő tulajdonsága (this[int idx]), amely lehetővé teszi az osztálynak,
        // hogy úgy viselkedjen, mint egy tömb. A get művelet visszaadja a megadott indexű elemet a tömbből,
        // míg a set művelet beállítja az adott indexű elem értékét a tömbben

        public int this[int idx]
        {
            get { return array[idx]; }
            set { array[idx] = value; }
        }

        // A tömb transzformációját végző metódus, amely paraméterül kap egy Transformer delegátumot
        // A delegátum egy olyan típus, amely hivatkozásokat tárol egy vagy több metódusra.
        // Ebben az esetben a Transformer delegátum egy olyan metódusra mutat, amely egy ref int típusú
        // paramétert fogad és nem tér vissza semmilyen értékkel

        // Az Array osztálynak van egy Transform metódusa, amely egy Transformer delegátumot vár paraméterként.
        // Amikor meghívjuk a delegátumot, akkor a hozzárendelt metódus(ok) futnak le.
        // Ez a metódus végigmegy a tömb összes elemén, és meghívja a delegátumot mindegyik elemre,
        // a tömb elemeit módosítva a delegátum által definiált transzformációval
        public void Transform(Transformer t)
        {
            // Végigmegyünk a tömbön és meghívjuk a Transformer delegátumot mindegyik elemre
            for (int i = 0; i < array.Length; ++i)
            {
                t(ref array[i]);
            }
        }
    }

    // A fő program belépési pontja
    class Program
    {
        // Metódus, amely egy egész számot megváltoztat önmagával szorzás révén
        static public void TransformerMethod(ref int item)
        {
            item *= item;
        }

        // Fő metódus
        static void Main(string[] args)
        {
            // Létrehozunk egy új Array példányt 10 elemmel
            Array array = new Array(10);

            // Feltöltjük a tömböt az indexekkel
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = i;
            }
            
            // Meghívjuk az Array osztály Transform metódusát, és átadjuk neki a TransformerMethod metódust,
            // amely egy referenciát ad egy olyan metódusra, amely megváltoztatja egy int típusú változó értékét
            // önmagával szorozva
            array.Transform(Program.TransformerMethod);

            // Kiírjuk a tömb elemeit a konzolra
            for (int i = 0; i < array.Length; ++i)
            {
                Console.WriteLine(array[i]);
            }

            // Várakozás egy gombnyomásra, mielőtt befejezzük a programot
            Console.ReadKey();
        }
    }
}
