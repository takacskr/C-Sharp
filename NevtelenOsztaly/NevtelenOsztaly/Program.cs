using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var type1 = new { Value1 = "alma", Value2 = "körte" };

            Console.WriteLine(type1.Value1); //alma

            Console.ReadKey();
        }
    }
}