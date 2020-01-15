using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricArea
{
    public class Circle : GeometricFigure
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

    }
}
