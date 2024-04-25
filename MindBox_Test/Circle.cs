using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox_Test
{
    public class Circle : IShape
    {
        private double _radius;
        public double Radius 
        { 
            get => _radius;
            set => _radius = value <= 0 ? throw new ArgumentException("The radius of the circle must be greater than zero") : value;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
