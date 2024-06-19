using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        LinkedList<string> lList = new LinkedList<string>();
        lList.AddLast("apple");
        lList.AddLast("lemon");
        lList.AddLast("pineapple");
        lList.AddLast("grape");

        LinkedListNode<string>? current = lList.First;

        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}