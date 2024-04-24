using System;
using System.Collections.Generic;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddLast("alma");
            list.AddLast("dió");
            list.AddLast("körte");
            list.AddFirst("narancs");

            LinkedListNode<string> current = list.First;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            Console.ReadKey();
        }
    }
}