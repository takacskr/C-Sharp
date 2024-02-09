using System;
namespace TestApp
{
    class Program
    {
        public delegate void Test(int x);
        static void Main(string[] args)
        {
            // Létrehozunk egy Test típusú delegáltat, t néven, és inicializáljuk egy névtelen metódussal
            // A névtelen metódus paraméterként egy int x értéket kap, majd ezt a paramétert kiírjuk a konzolra
            Test t = delegate (int x)
            {
                Console.WriteLine(x);
            };

            t(10);

            Console.ReadKey();
        }
    }
}