using System;

namespace GenericExample
{
    public class Box<T>
    {
        private T value;

        public void SetValue(T value)
        {
            this.value = value;
        }

        public T GetValue()
        {
            return value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Box<int> intBox = new Box<int>();
            intBox.SetValue(10);
            Console.WriteLine("Int value: " + intBox.GetValue());

            Box<string> stringBox = new Box<string>();
            stringBox.SetValue("Hello, generics!");
            Console.WriteLine("String value: " + stringBox.GetValue());

            Box<double> doubleBox = new Box<double>();
            doubleBox.SetValue(3.14);
            Console.WriteLine("Double value: " + doubleBox.GetValue());
        }
    }
}