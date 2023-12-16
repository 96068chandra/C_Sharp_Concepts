using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public abstract class Shape
    {
  
        public double height;
        public double width;
        public double radius;
        public const float pi = 3.14f;
        public abstract double FindAreaOfTheShape();

    }

    public class Rectangle : Shape
    {
        public Rectangle(double height,double width)
        {
            this.height = height;
            this.width = width;
            
        }

        public override double FindAreaOfTheShape()
        {
            return height * width;
        }
    }
    public class Circle : Shape
    {
        public Circle(double _radius)
        {
            this.radius = _radius;
            
        }

        public override double FindAreaOfTheShape()
        {
            return pi*radius*radius;
        }
    }
    public class Triangle : Shape
    {
        public Triangle(double height,double width)
        {
            this.height = height;
                this.width = width;


            
        }

        public override double FindAreaOfTheShape()
        {
            return 0.5*width*height;
        }
    }
    public class Cone : Shape
    {
        public Cone(double radius,double height)
        {
            this.radius = radius;   
            this.height = height;

            
        }

        public override double FindAreaOfTheShape()
        {
            return pi*radius*(radius+Math.Sqrt(height*height+radius*radius));
        }
    }
    public class AbstractClassExample
    {
        static void Main5(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine($"Area of rectangle:{rectangle.FindAreaOfTheShape()}");
            Circle circle = new Circle(5);
            Console.WriteLine($"Area of Circle:{circle.FindAreaOfTheShape()}");
            Triangle triangle = new Triangle(10, 20);
            Console.WriteLine($"Area of Triangle:{triangle.FindAreaOfTheShape()}");
            Cone cone = new Cone(5, 10);
            Console.WriteLine($"Area of Cone:{cone.FindAreaOfTheShape()}");
            Console.ReadKey();






        }
    }
}
