﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netckracker2;

namespace netckracker2
{
    class FigureTest
    {
        public static bool TestCircle()
        {
            //arrange
            IFigure obj = new Circle(5);
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

        public static bool TestTriangleGetArea()
        {
            //arrange
            IFigure obj = new Triangle(2, 3, 4);
            double expected = 8.4375;
            //act
            double actual = obj.GetArea();
            //assert
            if (expected != actual)
            {
                return false;
            }
            return true;


        }

        public static bool TestTriangleIsRectangular()
        {
            //arrange
            Triangle notRect = new Triangle(2, 2, 2);
            Triangle rect = new Triangle(8, 6, 10);
            //assert
            if (rect.IsRectangular() != true)
            {
                return false;
            }

            if(notRect.IsRectangular() != false)
            {
                return false;
            }

            return true;
        }
    }
}
