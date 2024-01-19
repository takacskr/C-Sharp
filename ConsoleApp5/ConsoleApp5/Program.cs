using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaráljuk a nullable int tömböt
            int[][]? array = new int[10][];

            // Feltöltjük a tömböt alintömbökkel
            for (int i = 0; i < 10; ++i)
            {
                array[i] = new int[1000];
            }

            // Létrehozunk egy WeakReference objektumot, amely a tömbre mutat
            WeakReference weakReference = new WeakReference(array);

            // A tömbre mutató referenciát null-ra állítjuk
            array = null;

            // Ellenőrizzük, hogy a WeakReference még mindig hivatkozik-e valamire
            if (weakReference.Target != null)
            {
                // Ha igen, visszaállítjuk a tömbre mutató referenciát
                array = (int[][])weakReference.Target;
            }
            // Megjegyzés: A WeakReference használatakor ügyelni kell arra, hogy a Target ne legyen null,
            // mivel ez azt jelentené, hogy az eredeti objektum már eltávolításra került
        }
    }
}
