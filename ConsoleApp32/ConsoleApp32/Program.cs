using System;

/*
 * A class referenciatípust definiál, ami azt jelenti, hogy példányai referenciákra mutatnak,
 * és ezek az adatok a heap memóriában tárolódnak.
 
 * Ezzel szemben a struct értéktípust definiál,
 * ami azt jelenti, hogy azok az adatok a verem memóriában tárolódnak, és direktben az értékük tárolódik.
 */

namespace TestApp

// Class esetén az adatok tárolása a Heap-ben (halom)
// Struct esetén az adatok tárolása a Stack-ben (verem)
{
    // Ha struct helyett class használunk, akkor mindkét érték egyforma lesz mert ugyanarra a memóriaterületre
    // hivatkozik. Struct esetében viszont t2 létrehozásakor egy másik memóriaterületre történik a foglalás.
    struct Test
    {
        public int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = t1;
            t2.x = 10;
            Console.WriteLine($"t1.x = {t1.x}, t2.x = {t2.x}");
            Console.ReadKey();
        }
    }
}