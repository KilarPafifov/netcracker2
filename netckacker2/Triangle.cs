using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    class Triangle : IFigure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        
        public Triangle()
        {

        }
        public void SetSides(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsRectangular()
        {
            if ((a * a) + (b * b) == (c * c)
                || (c * c) + (b * b) == (a * a)
                || (a * a) + (c * c) == (b * b))
            {
                return true;
            }
            return false;
        }
        public double GetArea()
        {
            double p;
            p = (a + b + c) / 2;
            return p * (p - a) * (p - b) * (p - c);
        }
    }
}
