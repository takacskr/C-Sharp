namespace ConsoleApp36
{
    // Definiálunk egy MyInt nevű osztályt
    class MyInt
    {
        // Konstruktor, amely egy egész értéket vesz át, és hozzárendeli a Value tulajdonsághoz
        public MyInt(int value)
        {
            this.Value = value;
        }

        // Publikus Value tulajdonság egy privát Setterrel az érték beállításának kontrollálásához
        public int Value { get; private set; }

        // Az összeadás operátor túlterhelése a két MyInt objektum összeadásának lehetővé tétele érdekében
        public static MyInt operator +(MyInt lhs, MyInt rhs)
        {
            // Létrehozunk egy új MyInt objektumot az lhs és rhs értékeinek összegével
            return new MyInt(lhs.Value + rhs.Value);
        }
    }

    // Fő programosztály
    internal class Program
    {
        // Main metódus, a program belépési pontja
        static void Main(string[] args)
        {
            // Két MyInt objektum létrehozása 10 és 20 értékekkel
            MyInt x = new MyInt(10);
            MyInt y = new MyInt(20);

            // A két MyInt objektum összeadása az operátor túlterhelése révén
            MyInt result = x + y;

            // Az eredmény objektum értékének kiírása a konzolra
            Console.WriteLine(result.Value);
        }
    }
}
