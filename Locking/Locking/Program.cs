using System;
using System.Threading;

/*
 Az x változó static tagváltozó az Test osztályban, tehát az azonos osztályon belül minden példány (objektum)
ugyanazt az x változót használja. Mivel az x változó static, az osztályon belül egyetlen példánya van,
és minden objektum ugyanarra az x változóra hivatkozik.

Ezért a t1 és t2 szálak azonos x változót használják, még akkor is, ha a t2 később indítódik el.
Tehát a t1 indítása előtt a Test.x értéke még mindig 10 lesz, és ugyanez lesz a helyzet a t2 indítása előtt is.
A Divide metódusban történő Test.x ellenőrzése ezen értékre vonatkozik.
 */
class Test
{
    static int x = 10;
    static int y = 20;
    static public void Divide()
    {
        if (Test.x != 0)
        {
            Thread.Sleep(2);
            Console.WriteLine(Test.y / Test.x);
            Test.x = 0;

            /*
             a Test.x értéke csak akkor lesz 0, ha az egyik szál befejezi a végrehajtását,
             és a Divide metódusban az x értékét 0-ra állítjuk. Ha csak az egyik szál fut le a Divide metóduson keresztül,
             akkor a másik szál még mindig az eredeti x értéket használja.
             
            A t1 és t2 szálak elindulnak egymástól függetlenül.
            Mindkét szál belép a Divide metódusba.
            Mindkét szál megvizsgálja az x értékét, ami kezdetben 10.
            Ha az x értéke nem 0, mindkét szál alszik 2 milliszekundumig.
            Mindkét szál felébred, és kiszámítja az y / x értéket, ami 20 / 10 = 2. Ezt az értéket kiírják a konzolra.
            Mindkét szál befejezi a végrehajtását, és kilép a Divide metódusból.
            Amint látható, mindkét szál ugyanarra az x értékre hivatkozik, ami a Test osztály statikus változója,
            így mindkét szál ugyanarra az értékre fog hivatkozni, és csak akkor lesz 0, ha legalább az egyik szál befejezi
            a végrehajtását, és az x értékét beállítjuk 0-ra a Divide metódusban.
             */


        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(new ThreadStart(Test.Divide));
        Thread t2 = new Thread(new ThreadStart(Test.Divide));
        t1.Start();
        t2.Start();
    }
}