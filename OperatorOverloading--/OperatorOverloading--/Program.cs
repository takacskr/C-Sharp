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
    }
    internal class Program
    {
        static void Main()
        {
            MyInt x = new MyInt(10);
            Console.WriteLine(x.Value);
            ++x;

            Console.WriteLine(x.Value);
            MyInt y = x++;
            Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);
        }
    }
}
