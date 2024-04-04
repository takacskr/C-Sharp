using System;

namespace TestApp
{
    // Mivel a struktúrák érték típusúak, ezért azok példányai
    // nem módosíthatók, miután létrehozták őket.
    // Érték típusúak - átadásakor a másolatát adjuk át,
    // így a változtatások nem érintik az eredeti példányt.
    struct Point
    {
        int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    struct Line
    {
        Point a;
        public Point A
        {
            get { return a; }
            set { a = value; }
        }
        Point b;
        public Point B
        {
            get { return b; }
            set { b = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Line l = new Line();

            l.A = new Point(10, 13);
            Console.WriteLine($"l.A.X, l.A.Y = {l.A.X}, {l.A.Y}");

            l.B = new Point(20, 24);
            Console.WriteLine($"l.B.X, l.B.Y = {l.B.X}, {l.B.Y}");

            l.A = new Point(5, 15);
            Console.WriteLine($"l.A.X, l.A.Y = {l.A.X}, {l.A.Y}");


            Console.ReadKey();
        }
    }
}