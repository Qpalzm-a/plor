using System;

namespace plor8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.a = 3;

            Circle circle = new Circle();
            circle.r = 5;

            Triangle triangle = new Triangle();
            triangle.a = 1;
            triangle.h = 2.6;

            AbstractCall(square);
            Console.WriteLine();
            AbstractCall(circle);
            Console.WriteLine();
            AbstractCall(triangle);
        }


        static public void AbstractCall(Shape shape)
        {
            Console.WriteLine(shape.GetPerimeter());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.a);
        }
    }


    abstract class Shape
    {
        public double a { get; set; }

        public abstract double GetPerimeter();

        public abstract double GetArea();
    }

    class Square : Shape
    {
        public override double GetPerimeter()
        {
            return a * 4;
        }

        public override double GetArea()
        {
            return a * a;
        }


        public double GetDiagonal()
        {
            return Math.Sqrt(2 * a);
        }


    }

    class Circle : Shape
    {
        public double r { get; set; }
        public override double GetPerimeter()
        {
            return r * 2 * 3.14;
        }

        public override double GetArea()
        {
            return r * r * 3.14;
        }

        public double GetDiameter()
        {
            return r * 2;
        }
    }

    class Triangle : Shape
    {
        public double b { get; set; }
        public double c { get; set; }
        public double h { get; set; }
        
        public override double GetPerimeter()
        {
            return a + b + c;
        }

        public override double GetArea()
        {
            return a * 0.5 * h;
        }

        public double GetMedian()
        {
            return 0.5 * Math.Sqrt(2 * (b * b + c * c) - a * a);
        }
    }
}
