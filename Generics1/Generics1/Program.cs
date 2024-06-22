using System;

namespace TestApp
{
    class Test<T>
    {
        public static T? Value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test<int>.Value = 10;
            Test<string>.Value = "Twenty"; // Now using a string

            Console.WriteLine(Test<int>.Value); // 10
            Console.WriteLine(Test<string>.Value); // Twenty


            if (Test<string>.Value is string)
            {
                Console.WriteLine("Az érték string!");
            }

            Console.ReadKey();
        }
    }
}
