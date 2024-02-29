using System;
using System.Linq.Expressions;
class Program
{
    static void Main(string[] args)
    {
        Expression<Func<int, int, bool>> expression = (x, y) => (x > y);
        Console.WriteLine(expression.Compile().Invoke(10, 2)); // True
        Console.ReadKey();
    }
}