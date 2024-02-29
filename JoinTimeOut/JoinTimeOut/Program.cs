using System;
using System.Threading;

/*
Létrehozunk egy új mellékszálat (t), ami egy anonim metódust hajt végre, ami 2000 milliszekundumig (2 másodpercig) alszik.
A t mellékszál elindul a Start() metódus meghívásával.
A főszál megpróbál csatlakozni 'Join() metódussal' a t mellékszállal 1000 milliszekundum időkorláttal.
Ha a t mellékszál nem fejeződik be 1000 milliszekundumon belül, akkor a főszál kiírja a "Az idő lejárt..." üzenetet a konzolra.
A főszál megszakítja 'Interrupt()' a t mellékszálat.
A program befejezi a futását.
 */

namespace JoinTimeOut
{
    internal class Program
    {
        static void Main()
        {
            Thread t = new Thread( () => Thread.Sleep(2000) );
            t.Start();

            if (t.Join(1000) == false)
            {
                Console.WriteLine("Az idő lejárt...");
                t.Interrupt(); // megszakítjuk a mellékszál futását
            }
        }
    }
}
