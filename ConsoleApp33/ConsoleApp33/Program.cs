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
            this.x = x;
            this.y = y;
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
            l.A = new Point(10, 10);
            l.B = new Point(20, 20);
            l.A = new Point(5, 10);
            Console.ReadKey();
        }
    }
}