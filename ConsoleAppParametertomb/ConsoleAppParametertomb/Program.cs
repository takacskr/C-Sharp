namespace ConsoleAppParametertomb
{
    class Test
    {
        // Paramétertömb használata
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
            Test t = new Test();
            t.PrintElements("alma", "körte", 1, 4, "dió");
            t.PrintElements();
        }
    }
}
