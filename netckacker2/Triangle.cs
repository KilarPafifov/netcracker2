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
        private double p;
        public Triangle()
        {
            a = 2;
            b = 3;
            c = 4;
            p = (a + b + c) / 2;
        }

        public double GetArea()
        {
            return p * (p - a) * (p - b) * (p - c);
        }
    }
}
