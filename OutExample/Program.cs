using System;

/*
    With out, the parameter does not need to be initialized before it's passed to the method.
    The method must assign a value to the parameter before it returns.
    It indicates that the parameter is being used to return multiple values from the method.
    It's typically used when the method needs to return more than one value and one of those
    values is the actual return value of the method.

    out should be used:
    - When you want a method to return multiple values.
    - When you need a method to return a value as well as perform some operation and modify the passed variable.
    - When you want to ensure that the variable passed as out is always assigned a value within the method.
    - When you want to explicitly indicate to the caller that the variable will be assigned a value inside the method.
 */

class Program
{
    static void Main(string[] args)
    {
        int result;

        // Call the method with out keyword
        AddNumbers(5, 3, out result);
        Console.WriteLine("Result of addition: " + result);
    }

    // Method to add two numbers and return the result using out keyword
    static void AddNumbers(int a, int b, out int sum)
    {
        sum = a + b;
    }
}
