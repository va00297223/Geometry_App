using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryApp_Library
{
    public class Rectangle : IShape
    {
        private readonly double l;
        private readonly double w;

        public Rectangle(double length, double width)
        {
            this.l = length;
            this.w = width;
        }

        public double CalculateArea()
        {
            return l * w;
        }

        public double CalculatePerimeter()
        {
            return 2 * (l + w);
        }
    }
}
