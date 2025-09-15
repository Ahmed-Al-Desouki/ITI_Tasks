using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4_CSharp
{
    public abstract class Shape
    {
        public string Name { get; set; }

        protected Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();
    }

    // ------------------ Interface ------------------
    public interface IDrawable
    {
        void Draw();
    }

    // ------------------ Circle ------------------
    public class Circle : Shape, IDrawable
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Circle:");
            Console.WriteLine("   ***   ");
            Console.WriteLine(" *     * ");
            Console.WriteLine("   ***   ");
        }
    }

    // ------------------ Rectangle ------------------
    public class Rectangle : Shape, IDrawable
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) : base("Rectangle")
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle:");
            Console.WriteLine("********");
            Console.WriteLine("*      *");
            Console.WriteLine("********");
        }
    }
    internal class program3
    {
        //static void Main(string[] args)
        //{
        //    List<Shape> shapes = new List<Shape>
        //    {
        //        new Circle(3),
        //        new Rectangle(4, 6)
        //    };

        //    foreach (var shape in shapes)
        //    {
        //        Console.WriteLine($"\nShape: {shape.Name}");
        //        Console.WriteLine($"Area = {shape.Area()}");

        //        if (shape is IDrawable drawable)
        //        {
        //            drawable.Draw();
        //        }
        //    }
        //}
    }
}
