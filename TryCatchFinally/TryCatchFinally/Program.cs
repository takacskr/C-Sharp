using System;

class Program
{
    static void Main()
    {
        try
        {
            // Itt helyezd el a kódodat, amelynek a kivételkezelését szeretnéd megvalósítani
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("A tömb 4. eleme: " + numbers[3]); // Ez dob egy IndexOutOfRangeException-t
        }
        catch (IndexOutOfRangeException ex)
        {
            // Ez a rész fut le, ha az IndexOutOfRangeException kivétel megtörténik
            Console.WriteLine("Hiba történt: Indexelési tartományon kívüli hiba.");
            Console.WriteLine("Részletek: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Ez a rész fut le, ha bármilyen más kivétel megtörténik (amelyet nem kezeltünk előbb)
            Console.WriteLine("Általános hiba történt.");
            Console.WriteLine("Részletek: " + ex.Message);
        }
        finally
        {
            // Ez a rész mindig lefut, függetlenül attól, hogy történt-e kivétel vagy sem
            Console.WriteLine("A finally blokk lefutott.");
        }
    }
}
