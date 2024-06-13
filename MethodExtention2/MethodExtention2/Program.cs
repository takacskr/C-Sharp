using System;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is Point other)
        {
            return X == other.X && Y == other.Y;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = new Point { X = 1, Y = 2 };

        Console.WriteLine(p1.Equals(p2)); // Output: True (Points have same coordinates)
    }
}