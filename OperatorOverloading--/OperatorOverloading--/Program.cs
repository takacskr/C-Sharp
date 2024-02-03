namespace OperatorOverloading__
{
    class MyInt
    {
        public MyInt(int value)
        {
            this.Value = value;
        }

        public int Value { get; private set; }

        static public MyInt operator ++(MyInt rhs)
        {
            ++rhs.Value;
            return rhs;
        }

        static public implicit operator MyInt(int rhs)
        {
            return new MyInt(rhs);
        }

        static public explicit operator MyInt(string rhs)
        {
            return new MyInt(int.Parse(rhs));
        }
    }
    internal class Program
    {
        static void Main()
        {
            /*
            MyInt x = new MyInt(10);
            Console.WriteLine(x.Value);
            ++x;

            Console.WriteLine(x.Value);
            MyInt y = x++;
            Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);
            */

            MyInt x = 10;
            MyInt y = (MyInt)"20";

            Console.WriteLine("x értéke: {0}", x.Value);
            Console.WriteLine("y értéke: {0}", y.Value);
        }
    }
}
