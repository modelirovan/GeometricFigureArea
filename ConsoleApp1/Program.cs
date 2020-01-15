using System;
using GeometricArea;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(radius: 15);
            var circleArea = circle.Area();

            var triangle = new Triangle(10, 10, 10);
            var triangleArea = triangle.Area();

            Console.WriteLine("Hello World!");
        }
    }
}
