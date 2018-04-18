using System;

namespace OO_Tasks_Inheritence
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public string Colour { get; set; }

        public Shape(string name, string colour)
        {
            Name = name;
            Colour = colour;
        }

        public abstract double GetPerimeter();

        public abstract double GetArea();
    }

    public abstract class Quadrilateral : Shape
    {
        public int NumSides { get; set; } = 4;

        public Quadrilateral(string name, string colour) : base(name, colour) { }
    }

    public class Square : Shape
    {
        private double SideLength { get; set; } = 4;

        public Square(string name, string colour, double sideLength) : base(name, colour)
        {
            SideLength = sideLength;
        }

        public override double GetPerimeter()
        {
            return Math.Round (4 * SideLength,2);
        }

        public override double GetArea()
        {
            return Math.Round (SideLength * SideLength,2);
        }
    }

    public class Rectangle : Shape
    {
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle(string name, string colour, double length, double width) : base(name, colour)
        {
            Length = length;
            Width = width;
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * (Length + Width), 2);
        }

        public override double GetArea()
        {
            return Math.Round(Length * Width, 2);
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public const double PI = 3.142;

        public Circle(string name, string colour, double radius) : base(name, colour)
        {
            Radius = radius;
        }

        public override double GetPerimeter()
        {
            return GetCircumference();
        }

        public override double GetArea()
        {
            return Math.Round ( PI * Math.Pow(Radius, 2), 2);
        }

        public double GetCircumference()
        {
            return Math.Round (2 * PI * Radius, 2);
        }
    }
}
