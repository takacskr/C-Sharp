using System;
using System.Collections.Generic;

namespace Generikusok2
{
    class Stack<T>
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

        // The Pop() method removes the last element
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

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>(10);
            for (int i = 0; i < 10; ++i)
            {
                s.Push(i);
            }
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(s.Pop());
            }

            Console.ReadKey();
        }
    }
}