namespace EqualOperator
{
    class MyInt
    {
        public MyInt(int value)
        {
            this.Value = value;
        }

        public int Value { get; private set; }

        public static MyInt operator +(MyInt x, MyInt y)
        {
            return new MyInt(x.Value + y.Value);
        }

        public static bool operator ==(MyInt x, MyInt y)
        {
            return x.Value == y.Value;
        }

        static public bool operator !=(MyInt x, MyInt y)
        {
            return !(x == y);
        }

        public override bool Equals(object? y)
        {
            if (!(y is MyInt))
            {
                return false;
            }

            return this == (MyInt)y;
        }

        public override int GetHashCode()
        {
            return this.Value << 2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
