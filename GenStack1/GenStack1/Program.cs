using System;

public class Stack<T>

    // csak értékípusú generikus paraméterrel példányosíthatjuk
    where T : struct
{
    public int capacity;
    public int pointer;
    private T[] items;

    public Stack(int capacity)
    {
        this.capacity = capacity;
        items = new T[capacity];
        pointer = -1;
    }

    public void Push(T element)
    {
        if (pointer == capacity - 1)
        {
            throw new ArgumentException("Stack overflow");
        }
        items[++pointer] = element;
    }

    public T Pop()
    {
        if (pointer == -1)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return items[pointer--]; // Decrement pointer after accessing element
    }
}

public class Program
{
    public static void Main()
    {
        Random rnd = new Random(100); // Different seed each time
        Stack<int> stack = new Stack<int>(10);

        for (int i = 0; i < 10; i++)
        {
            stack.Push(rnd.Next(0, 100)); // Explicit casting (optional)
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(stack.Pop());
        }

        // Check stack size after popping (pointer is already updated)
        int remainingElements = stack.pointer + 1;
        Console.WriteLine($"Stack size after popping: {remainingElements}");
    }
}
