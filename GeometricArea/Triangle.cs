using System;

namespace GeometricArea
{
    public class Triangle : GeometricFigure
    {
        public double ASide { get; set; }
        public double BSide { get; set; }
        public double CSide { get; set; }

        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        public override double Area()
        {
            var p = (ASide + BSide + CSide) / 2;
            var s = Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
            return s;
        }
    }
}
