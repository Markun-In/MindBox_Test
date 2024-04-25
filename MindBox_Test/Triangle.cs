using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Test
{
    public class Triangle : IShape
    {
        private double _side1, _side2, _side3;
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("The side of the triangle must not be less than or equal to zero");

            if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
                throw new ArgumentException("One of the sides of the triangle is greater than the sum of the other two");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double CalculateArea()
        {
            double semiPer = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(semiPer * (semiPer - Side1) * (semiPer - Side2) * (semiPer - Side3));
        }

        public bool IsRightAngleTriangle()
        {
            double[] sides = { Side1, Side2, Side3 };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }
}
