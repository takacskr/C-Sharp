namespace yieldTest3
{
    /*
     * Ahogy látható, a GetNumbers metódus részletekben fut le, a yield return utasítások értékeket állítanak elő a sorozatban,
     * és a Console.WriteLine utasítások futnak le közben. A yield break utasítás nem érhető el, mert a foreach ciklus abbahagyja
     * az enumerálást a harmadik érték után.
     * 
     * A yield kulcsszó egy nagyon hasznos eszköz az értékek sorozatának előállítására, és sok alkalmazása van olyan területeken,
     * mint az adatfeldolgozás, az aszinkron programozás és a kooperatív multitasking.
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> GetNumbers()
            {
                Console.WriteLine("Kezdés");
                yield return 1;
                Console.WriteLine("1 után");
                yield return 2;
                Console.WriteLine("2 után");
                yield return 3;
                Console.WriteLine("3 után");
                yield break;
                Console.WriteLine("Vég");
            }

            foreach (int number in GetNumbers())
            {
                Console.WriteLine(number);
            }
        }
    }
}
