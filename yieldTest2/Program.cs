using System;
using System.Collections.Generic;

/*
 * A yield kulcsszó a C#-ban egy értéket állít elő az IEnumerable vagy IEnumerator objektumban.
 * Főleg az iterator blokkokban használják a értékek sorozatának előállítására.

Íme, hogyan működik a yield:

- Lassú kiértékelés: Amikor egy metódust hívnak, amely tartalmaz egy yield utasítást, az nem fut le azonnal.
Ehelyett egy IEnumerable vagy IEnumerator objektumot ad vissza, amelyet, amikor enumerálják, lefut a metódus és előállítja az értékek sorozatát.

- Állapotgép: A fordító egy állapotgépet generál, amely nyomon követi az iterator aktuális állapotát.
Ezt az állapotgépet használják arra, hogy emlékezzen az aktuális pozícióra a sorozatban, és folytassa a végrehajtást onnan, ahol abbahagyta,
amikor az iterator újra enumerálva van.

- Yield Return: A yield return utasítás egy értéket állít elő a sorozatban.
Amikor a yield return utasításra érkezünk, a metódus visszatér a hívóhoz, de emlékszik az aktuális állapotra.
Amikor az iterator újra enumerálva van, a végrehajtás folytatódik onnan, ahol abbahagyta.

- Yield Break: A yield break utasítás jelzi a sorozat végét. Amikor a yield break utasításra érkezünk,ű
az iterator leáll, és több értéket nem állít elő.
 */

class Program
{
    internal static void Main()
    {
        foreach (int number in GenerateNumbers(10))
        {
            Console.WriteLine(number);
        }
    }

    public static IEnumerable<int> GenerateNumbers(int max)
    {
        for (int i = 0; i < max; i++)
        {
            yield return i;
        }
    }
}