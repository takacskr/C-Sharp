using System;

namespace Delegate2
{
    class Test
    {
        public void Method() { }
    }

    internal class Program
    {
        public delegate void TestDelegate();

        public static void Method1() { }
        public static void Method2() { }

        static void Main()
        {
            TestDelegate t1 = null;
            TestDelegate t2 = null;

            Console.WriteLine(t1 == t2); // True

            t1 = Program.Method1;
            t2 = Program.Method1;
            Console.WriteLine(t1 == t2); // True

            t1 += Program.Method2;
            Console.WriteLine(t1 == t2); // False

            t1 -= Program.Method2;
            Console.WriteLine(t1 == t2); // True

            Test x = new Test();
            Test y = new Test();

            // Mindkét Test objektum ugyanazt a metódust tartalmazza, de azok hivatkozása különböző,
            // mivel különböző objektumokra mutatnak. Ezért az összehasonlítás False értéket ad vissza
            t1 += x.Method;
            t2 += y.Method;

            Console.WriteLine(t1 == t2); // False
        }
    }
}
