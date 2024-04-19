using System;

/*
    With ref, the parameter must be initialized before it's passed to the method.
    The method can read and modify the value of the parameter.
    It indicates that the parameter is passed by reference, meaning any changes made to the parameter
    within the method will affect the original variable passed to it.
    It is not required for the method to assign a value to the parameter.

    ref should be used:
    - When you want to pass a variable by reference to a method and you expect the method to modify the value of that variable.
    - When you need to pass a value type variable by reference.
    - When the variable passed as ref may or may not be initialized before being passed to the method.
 */

class Program
{
    static void Main(string[] args)
    {
        int number = 5;

        // Call the method with ref keyword
        Console.WriteLine("Before calling DoubleNumber method: " + number);

        DoubleNumber(ref number);
        Console.WriteLine("After calling DoubleNumber method: " + number);
    }

    // Method to double the value of a number using ref keyword
    static void DoubleNumber(ref int num)
    {
        num *= 2;
    }
}
