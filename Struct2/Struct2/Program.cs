public struct Coordinate
{
    public int X { get; }
    public int Y { get; }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        Coordinate point = new Coordinate(10, 20);
        Coordinate point2 = new Coordinate(30, 60);
        Console.WriteLine("X koordináta: " + point.X);
        Console.WriteLine("Y koordináta: " + point.Y);

        Console.WriteLine("X koordináta: " + point2.X);
        Console.WriteLine("Y koordináta: " + point2.Y);
    }
}
