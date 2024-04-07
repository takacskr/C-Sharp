using System;

namespace PolymorphismExample
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculateCircumference();
    }

    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double givenRadius = 4.14;
            Shape circle = new Circle(givenRadius);

            double circumference = circle.CalculateCircumference();
            Console.WriteLine($"The circumference of the circle: {circumference}");

            double area = circle.CalculateArea();
            Console.WriteLine($"The area of the circle: {area}");
        }
    }
}