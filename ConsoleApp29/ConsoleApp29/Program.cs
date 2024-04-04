namespace ConsoleApp29
{
    class Test
    {
        public static int Var = Test.Init();

        // 1.) A statikus adattagok inicializálása történik meg legelőször,
        // mielőtt bármilyen példányosítás vagy más osztályfunkciók meghívása történne.
        // A statikus adattagok az osztályhoz tartoznak, és az osztály betöltésekor inicializálódnak.
        public static int Init()
        {
            Console.WriteLine($"Var értéke: 10");
            return 10;
        }

        // 3.) ..majd a Main metódusban megtörténik a példányosítás, és lefut a konstruktor
        public Test()
        {
            Console.WriteLine("Konstruktor");
        }

        // 2.) Ezt követően fut le a statikus konstruktor
        static Test()
        {
            Console.WriteLine("Statikus konstruktor");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");
         
            Test t = new();
        }
    }
}
