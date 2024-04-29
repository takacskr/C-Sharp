using System;

class Calculator
{
    // Metódus, amely két számot vesz fel és végrehajt egy adott műveletet az Action<> delegált segítségével
    public void PerformOperation(int a, int b, Action<int, int> operation)
    {
        operation(a, b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        // Összeadás művelet
        Action<int, int> add = (x, y) =>
        {
            int result = x + y;
            Console.WriteLine($"Összeg: {result}");
        };

        // Kivonás művelet
        Action<int, int> subtract = (x, y) =>
        {
            int result = x - y;
            Console.WriteLine($"Különbség: {result}");
        };

        // Műveletek végrehajtása a Calculator osztály segítségével
        int operand1 = 10;
        int operand2 = 5;

        calculator.PerformOperation(operand1, operand2, add);
        calculator.PerformOperation(operand1, operand2, subtract);
    }
}
