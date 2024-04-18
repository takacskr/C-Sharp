using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            // A new int[10][] egy olyan tömböt reprezentál, amely 10 elemet (tömböt) képes tárolni.
            // Minden egyes elem egy int[] típusú tömbre mutat.
            // Ez lehetővé teszi, hogy különböző hosszúságú tömböket tárolj a fő tömb elemeiben.
            // Minden array tömb eleme egy ezer elemű, egész számokat tartalmazó tömb lesz.

            // Fontos megjegyezni, hogy az int[][]? típus lehetőséget ad arra,
            // hogy az array változó null értéket is tartalmazzon,
            // amennyiben például nem inicializáltuk volna azt a létrehozás után.
            // Azért használjuk a ? jelet, hogy jelezzük, ez a változó null értéket is felvehet.
            int[][]? array = new int[10][];

            // Feltöltjük a tömböt alintömbökkel
            for (int i = 0; i < 10; ++i)
            {
                array[i] = new int[1000];
            }

            // Létrehoz egy gyenge hivatkozást (WeakReference), amely az array tömbre mutat.
            // A gyenge hivatkozás lehetővé teszi az objektum eltávolítását a memóriából, ha nincs más referencia rá.
            WeakReference weakReference = new WeakReference(array);

            /* A tömbre mutató referenciát null-ra állítjuk, így az erős referencia megszűnik.
            Ha nem lenne gyenge hivatkozás, akkor az objektumra sem lenne más hivatkozás.
            Ennek eredményeként az objektumot a szemétgyűjtő eltávolítaná a memóriából, mivel nincs rá mutató erős referencia.

            A gyenge hivatkozás használata lehetővé teszi számunkra, hogy továbbra is hivatkozzunk az objektumra anélkül,
            hogy megakadályoznánk a szemétgyűjtőt az eltávolításában, ha már nincs rá más erős referencia.
            
            Ez hasznos lehet például akkor, ha ideiglenesen meg akarjuk tartani az objektumot,
            de nem akarjuk megakadályozni, hogy a szemétgyűjtő eltávolítsa, amikor már nincs rá szükségünk.
            */

            array = null;

            // Ellenőrizzük, hogy a WeakReference még mindig hivatkozik-e valamire
            if (weakReference.Target != null)
            {
                // Ha igen, visszaállítjuk a tömbre mutató referenciát
                array = (int[][])weakReference.Target;
                Console.WriteLine("A WeakReference még mindig hivatkozik - visszaállítjuk a tömbre mutató referenciát!");
            }
            // Megjegyzés: A WeakReference használatakor ügyelni kell arra, hogy a Target ne legyen null,
            // mivel ez azt jelentené, hogy az eredeti objektum már eltávolításra került
        }
    }
}
