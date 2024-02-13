using System;

namespace GenerikusTagok
{
    class Test<T>
    {
        public static T Value;
    }

    class Program
    {
        static void Main()
        {
            Test<int>.Value = 10;
            Test<string>.Value = "alma";

            Console.WriteLine(Test<int>.Value);
            Console.WriteLine(Test<string>.Value);
        }
    }
}