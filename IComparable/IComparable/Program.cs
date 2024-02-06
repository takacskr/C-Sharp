using System.Collections;

namespace Compare
{
    class ComparableClass : IComparable
    {
        public ComparableClass(int value)
        {
            this.Value = value;
        }
        public int Value { get; private set; }
        public int CompareTo(object o)
        {
            if (o is ComparableClass)
            {
                ComparableClass c = (ComparableClass)o;
                return Value.CompareTo(c.Value);
            }
            else throw (new Exception("Nem megfelelõ objektum..."));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ComparableClass> list = new List<ComparableClass>();
            Random r = new Random();
            for (int i = 0; i < 10; ++i)
            {
                list.Add(new ComparableClass(r.Next(1000)));
            }
            foreach (ComparableClass c in list)
            {
                Console.Write("{0} ", c.Value);
            }
            Console.WriteLine("\nA rendezett lista:");
            list.Sort();
            
            foreach (ComparableClass c in list)
            {
                Console.Write("{0} ", c.Value);
            }
        }
    }
}
