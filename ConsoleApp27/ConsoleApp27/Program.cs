using System;
using System.Collections;

namespace ConsoleApp27
{
    class Names
    {
        /* Az ArrayList a System.Collections névtérből származik,
        és egy dinamikus méretű, indexelhető kollekciót nyújt.
        Az ArrayList objektumokat tárol, azokhoz indexen keresztül
        lehet hozzáférni */

        // ADATMEZŐ
        private ArrayList nameList;

        // KONSTRUKTOR
        public Names()
        {
            // Inicializáljuk a nameList adattagot egy új ArrayList objektummal
            nameList = new ArrayList();

            nameList.Add("István");
            nameList.Add("Szandra");
            nameList.Add("Béla");
            nameList.Add("Balázs");
        }

        //  METÓDUS
        public int Cnt
        {
            get { return nameList.Count; }
        }

        // a this[int idx] indexelhető tulajdonság lehetővé teszi számunkra,
        // hogy a Names osztályt úgy használjuk, mintha egy tömb vagy lista lenne,
        // és az osztály elemeire indexeléssel hivatkozhatunk

        // INDEXELŐ PROPERTY
        public string this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < nameList.Count)
                {
                    return nameList[idx].ToString();
                }

                return null;
            }

            set
            {
                if (idx >= 0 && idx < nameList.Count)
                {
                    nameList[idx] = value;
                }
                else if (idx == nameList.Count) // Ha az index az utolsó elem után van, hozzáadhatunk egy új elemet
                {
                    nameList.Add(value);
                }
                // Egyébként nem teszünk semmit, mert az index érvénytelen
            }
        }

    }

    internal class Program
    {
        // A PROGRAM FŐ BELÉPÉSI PONTJA A MAIN FÜGGVÉNY
        static void Main()
        {
            Names n = new Names();

            for (int i = 0; i < n.Cnt; ++i)
            {
                Console.WriteLine(n[i]);
            }

            Console.ReadKey();
        }
    }
}
