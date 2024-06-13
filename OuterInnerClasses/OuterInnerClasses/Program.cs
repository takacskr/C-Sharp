using System;

class Outer
{
    private int value = 11;
    private Inner child;

    public Outer()
    {
        child = new Inner(this);
    }

    public void Do()
    {
        child.Do();
    }

    class Inner
    {
        Outer parent;
        public Inner(Outer o)
        {
            parent = o;
        }

        public void Do()
        {
            Console.WriteLine(parent.value);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Outer o = new Outer();
        o.Do();
    }
}