using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netckacker2;

namespace netckacker2
{
    class FigureTest
    {
        public static bool TestCircle()
        {
            //arrange
            IFigure obj = new Circle();
            double expected = 78.5;
            //act
            double actual = obj.GetArea();
            //assert
            if(expected != actual)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TestCircle());
            Console.ReadLine();
        }
    }
}
