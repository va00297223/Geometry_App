using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryApp_Library
{
    public class Triangle : IShape
    {
        private readonly double s1;
        private readonly double s2;
        private readonly double s3;

        public Triangle(double s1, double s2, double s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        public double CalculateArea()
        {
            double semi = CalculatePerimeter() / 2;
            return Math.Sqrt(semi * (semi - s1) * (semi - s2) * (semi - s3));
        }

        public double CalculatePerimeter()
        {
            return s1 + s2 + s3;
        }
    }
}
