namespace Generikusok2
{
    class Stack<T>
        where T : struct
    {
        T[] t;
        int pointer;
        readonly int size;
        public Stack(int capacity)
        {
            t = new T[capacity];
            size = capacity;
            pointer = 0;
        }

        public void Push(T item)
        {
            if (pointer >= size)
            {
                throw (new StackOverflowException("Tele van..."));
            }

            t[pointer++] = item;
        }

        public object Pop()
        {
            if (pointer-- >= 0)
            {
                return t[pointer];
            }

            pointer = 0;
            throw (new InvalidOperationException("Üres..."));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Stack<int> s = new Stack<int>(10);

            for (int i = 0; i < 10; i++)
            {
                s.Push(random.Next(1, 101));
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(s.Pop());
            }
        }
    }
}
