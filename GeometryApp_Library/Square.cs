using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryApp_Library
{
    public class Square : IShape
    {
        private readonly double s;

        public Square(double sideLength)
        {
            this.s = sideLength;
        }

        public double CalculateArea()
        {
            return s * s;
        }

        public double CalculatePerimeter()
        {
            return 4 * s;
        }
    }
}
