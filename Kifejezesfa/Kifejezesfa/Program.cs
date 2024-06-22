using System;
using System.Linq.Expressions;

public class Program
{
    public static void Main()
    {
        Expression<Func<int, int, bool>> expression = (x, y) => (x > y);
        Console.WriteLine(expression.Compile().Invoke(10, 10));
    }
}