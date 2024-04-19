using System;

namespace ConsoleApp6
{
    // Implementáljuk az IDisposable interfészt
    class DisposableClass : IDisposable
    {
        private bool disposed = false;
        
        // Az interfésztől kapott metódus
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Ez a metódus arra szolgál, hogy összehangoljuk a GC munkáját
        // a kézi erőforrás-felszabadítással
        private void Dispose(bool disposing)
        {
            // Ha az érték false, tehát még nem történt meg a felszabadítás
            if (!disposed)
            {
                if (disposing)
                {
                    // managed erõforrások felszabadítása
                }
                // unmanaged erõforrások felszabadítása
                disposed = true;
            }
        }
        ~DisposableClass()
        {
            Dispose(false);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DisposableClass disposableClass = new DisposableClass();
            Console.ReadKey();
        }
    }
}