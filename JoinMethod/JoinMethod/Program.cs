using System;
using System.Threading;

namespace JoinMethod
{
    internal class Program
    {
                            // A Main metódus az elsődleges, fő szál
        static void Main() // A Main metódus a hívó szál, ő hívja meg a Join() metódust
        {
            /*
             * A másik szál, amelyet a program létrehoz és meghív, az a t nevű új szál,
             * amelyet a Thread osztályból hozunk létre a Start() metódus meghívásával.
             * Ez a másodlagos szál, amely a Thread.Sleep(2000) metódust végrehajtja
             * az anonim metóduson belül, majd befejezi a futását. A Join() metódus meghívásával
             * a fő szál várakozik erre a másodlagos szálra, mielőtt folytatná a további műveleteket.
             */
            Thread t = new Thread(delegate() { Thread.Sleep(2000); });

            // Itt jön létre az új szál a Thread osztályból
            t.Start();
            t.Join();

            Console.WriteLine("Vége");
            Console.ReadKey();
        }
    }
}
