using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using netckacker2;
namespace netckracker2.test
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void TestTriangleGetArea()
        {
            //arrange
            IFigure obj = new Triangle(2, 3, 4);
            double expected = 8.4375;
            //act
            double actual = obj.GetArea();
            //assert
            Assert.AreEqual(expected, actual);


        }
    }
}
