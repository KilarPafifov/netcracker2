using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    class Circle : IFigure
    {
        private double radius;
        private double p;
        public Circle(double r)
        {
            p = 3.14;
            radius = r;
        }
        public double GetArea()
        {
            return p * Math.Pow(radius , 2);
        }
    }
}
