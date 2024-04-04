namespace ConsoleAppParametertomb
{
    class Test
    {
        // Paramétertömb használata
        // Ez a metódus egy "params" kulcsszóval ellátott paramétertömböt vár, így
        // a metódusnak változó számú argumentumot lehet átadni.
        // A paramétertömb típusa object[], azaz objektumok tömbje, tehát
        // bármilyen típusú objektumot fogadhat.
        public void PrintElements(params object[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new ();
            t.PrintElements("alma", "körte", 1, 4, "dió");
        }
    }
}
