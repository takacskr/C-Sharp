using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // Ez is szükséges!

namespace ReadOnlyCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A lista elemeit csakis konstruktorban tölthetjük fel
            List<string> list = new List<string>()
                {
                    "alma", "körte", "dió"
                };

            // Ez az adatszerkezet az elemeit csak olvasásra adja oda
            ReadOnlyCollection<string> roc = new ReadOnlyCollection<string>(list);

            foreach (string item in roc)
            {
                Console.WriteLine(item);
            }
        }
    }
}
