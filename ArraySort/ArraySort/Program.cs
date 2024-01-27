/* Az this indexer az egyik kulcsfontosságú elem az C# nyelvben, amely lehetővé teszi
 * az objektumokhoz tartozó adatok indexelését, hasonlóan egy tömbhöz vagy listahez.
 * Az indexer lehetőséget nyújt arra, hogy az objektumot úgy viselkedjen, mintha egy tömb lenne,
 * azaz különböző indexeken elérhetővé teszi az adatokat.
 * Ez a módszer lehetővé teszi az adatokhoz való hozzáférést és azok módosítását az objektumon belül
 * indexelés segítségével, ami sok esetben kényelmes és olvasható kód írását teszi lehetővé. */

namespace ConsoleApp34
{
    class Array
    {
        private int[] array; // Az adattag, amely tárolja a tömb elemeit.

        // Konstruktor létrehozza a tömböt a megadott hosszúsággal.
        public Array(int length)
        {
            array = new int[length];
        }

        // az Array osztály egy indexerrel van ellátva, amely egyetlen
        // egész számot (idx) vár paraméterként, és visszaadja vagy beállítja
        // az array adattagban tárolt tömb megfelelő indexű elemét.

        // Indexer, lehetővé teszi az elemek lekérdezését és beállítását a tömbben.
        // Az elem indexét várja és visszaadja az adott indexű elem értékét
        public int this[int idx]
        {
            get { return array[idx]; }
            set { array[idx] = value; }
        }

        // Property, amely visszaadja a tömb hosszát.
        public int Length
        {
            get { return array.Length; }
        }

        // Rendezés a QuickSort algoritmussal.
        public void Sort()
        {
            QuickSort(0, array.Length - 1);
        }

        // Privát metódus a QuickSort algoritmus megvalósítására.
        private void QuickSort(int left, int right)
        {
            int pivot = array[left];
            int lhold = left;
            int rhold = right;

            while (left < right)
            {
                while (array[right] >= pivot && left < right)
                {
                    --right;
                }

                if (left != right)
                {
                    array[left] = array[right];
                    ++left;
                }

                while (array[left] <= pivot && left < right)
                {
                    ++left;
                }

                if (left != right)
                {
                    array[right] = array[left];
                    --right;
                }
            }

            array[left] = pivot;
            pivot = left;
            left = lhold;
            right = rhold;

            if (left < pivot)
            {
                QuickSort(left, pivot - 1);
            }

            if (right > pivot)
            {
                QuickSort(pivot + 1, right);
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            Array myArray = new Array(6);

            myArray[0] = 3;
            myArray[1] = 9;
            myArray[2] = 4;
            myArray[3] = 6;
            myArray[4] = 8;
            myArray[5] = 11;

            myArray.Sort();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "; ");
            }

            Console.WriteLine();
        }
    }
}
