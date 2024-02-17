using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ReadOnlyCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
                {
                    "alma", "körte", "dió"
                };

            ReadOnlyCollection<string> roc = new ReadOnlyCollection<string>(list);

            foreach (string item in roc)
            {
                Console.WriteLine(item);
            }
        }
    }
}
