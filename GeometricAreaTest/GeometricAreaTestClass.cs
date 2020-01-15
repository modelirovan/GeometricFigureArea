using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using GeometricArea;

namespace GeometricAreaTest
{
    public class GeometricAreaTestClass
    {

        public static IEnumerable<object[]> CircleCalculateAreaData()
        {
            yield return new object[]
                     {
                        15,
                        706.858
                     };

            yield return new object[]
                    {
                        10,
                        314.159
                    };
        }

        [Theory]
        [MemberData(nameof(CircleCalculateAreaData))]
        public void CircleCalculateArea_ShouldCalculateArea(double radius, double area)
        {
            var circle = new Circle(radius);

            var calculatedArea = Math.Round(circle.Area(), 3);

            Assert.Equal(area, calculatedArea);
        }
        public static IEnumerable<object[]> TriangleCalculateAreaData()
        {
            yield return new object[]
                     {
                        15,
                        2,
                        15,
                        14.967
                     };

            yield return new object[]
                    {
                        10,
                        10,
                        3,
                        14.830
                    };
        }

        [Theory]
        [MemberData(nameof(TriangleCalculateAreaData))]
        public void TriangleCalculateArea_ShouldCalculateArea(double sideA, double sideB, double sideC, double area)
        {
            var triangle = new Triangle(sideA, sideB, sideC);

            var calculatedArea = Math.Round(triangle.Area(), 3);

            Assert.Equal(area, calculatedArea);
        }
    }
}
