using System;
using System.Collections;

namespace ConsoleApp27
{
    class Names
    {
        /* Az ArrayList az System.Collections névtérből származik,
        és egy dinamikus méretű, indexelhető kollekciót nyújt.
        Az ArrayList objektumokat tárol és hozzáférésüket
        indexekkel lehet megadni. */
        private ArrayList nameList;

        public Names()
        {
            // Az ArrayList objektumokat tárolhat és azokhoz
            // indexen keresztül hozzáférhet

            // Inicializáljuk a nameList adattagot egy új ArrayList objektummal
            nameList = new ArrayList();
            nameList.Add("István");
            nameList.Add("Szandra");
            nameList.Add("Béla");
            nameList.Add("Balázs");
        }

        public int Cnt
        {
            get { return nameList.Count; }
        }

        // a this[int idx] indexelhető tulajdonság lehetővé teszi számunkra,
        // hogy a Names osztályt úgy használjuk, mintha egy tömb vagy lista lenne,
        // és az osztály elemeire indexeléssel hivatkozhatunk
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
        }
    }
    internal class Program
    {
        static void Main(string[] args)
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
