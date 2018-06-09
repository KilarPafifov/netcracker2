using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    class ArrayVectorTest
    {
        public static bool TestSet()
        {
            //arrange
            IArrayVector expected = new ArrayVector(new double[] { 1, 2, 3, 4, 5 });
            IArrayVector actual = new ArrayVector();

            //act
            actual.Set(new double[] { 1, 2, 3, 4, 5 });

            //assert
            return (Enumerable.SequenceEqual(actual.Get(), expected.Get()));
        }
        public static bool TestGet()
        {
            //arrange
            IArrayVector instance = new ArrayVector(new double[] { 1, 2, 3, 4 });
            double[] expected = new double[] { 1, 2, 3, 4 };

            //act
            double[] actual = instance.Get();

            //assert
            return Enumerable.SequenceEqual(actual, expected);
        }
        public static bool TestSetByIndex1()
        {
            #region Test
            //arrange
            IArrayVector actual = new ArrayVector(new double[] { 1, 2, 3, 4, 5 });
            IArrayVector expected = new ArrayVector(new double[]{ 1, 2, 3, 4, 5 });
            
            //act
            actual.Set(-1, 6);

            //assert
            return (Enumerable.SequenceEqual(actual.Get(), expected.Get()));
            #endregion
           
        }
        public static bool TestSetByIndex2()
        {
            #region Test 
            //arrange
            IArrayVector actual = new ArrayVector(new double[] { 1, 2, 3, 4, 5 });
            IArrayVector expected = new ArrayVector(new double[] { 1, 2, 3, 4, 5, 6 });

            //act
            actual.Set(11, 6);

            //assert
            return (Enumerable.SequenceEqual(actual.Get(), expected.Get()));
            #endregion

        }
        public static bool TestSetByIndex3()
        {
            #region Test
            //arrange
            IArrayVector actual = new ArrayVector(new double[] { 1, 2, 3, 4, 5 });
            IArrayVector expected = new ArrayVector(new double[] { 6, 2, 3, 4, 5 });

            //act
            actual.Set(0, 6);

            //assert
            return (Enumerable.SequenceEqual(actual.Get(), expected.Get()));
            #endregion
        }
        public static bool TestSetByIndex4()
        {
            #region Test
            //arrange
            IArrayVector actual = new ArrayVector(new double[] { 1, 2, 3, 4, 5 });
            IArrayVector expected = new ArrayVector(new double[] { 1, 2, 6, 4, 5 });

            //act
            actual.Set(2, 6);

            //assert
            return (Enumerable.SequenceEqual(actual.Get(), expected.Get()));
            #endregion
        }
        public static bool TestSetByIndex5()
        {
            #region Test
            //arrange
            IArrayVector actual = new ArrayVector(new double[] { 1, 2, 3, 4, 5 });
            IArrayVector expected = new ArrayVector(new double[] { 1, 2, 3, 4, 6 });

            //act
            actual.Set(4, 6);

            //assert
            return (Enumerable.SequenceEqual(actual.Get(), expected.Get()));
            #endregion
        }
        public static bool TestGetMax1()
        {
            //arrange
            IArrayVector instance = new ArrayVector(new double[] { 1, 2, 3, 4 });
            double expected = 4;
  
            //act
            double actual = instance.GetMax();

            //assert
            return actual == expected;
        }
        public static bool TestGetMax2()
        {
            //arrange
            IArrayVector instance = new ArrayVector(new double[] { 4, 2, 3, 1 });
            double expected = 4;

            //act
            double actual = instance.GetMax();

            //assert
            return actual == expected;
        }
        public static bool TestGetMax3()
        {
            //arrange
            IArrayVector instance = new ArrayVector(new double[] { 1, 4, 3, 2 });
            double expected = 4;

            //act
            double actual = instance.GetMax();

            //assert
            return actual == expected;
        }
        public static bool TestGetMin1()
        {
            //arrange
            IArrayVector instance = new ArrayVector(new double[] { 1, 2, 3, 4 });
            double expected = 1;

            //act
            double actual = instance.GetMin();

            //assert
            return actual.Equals(expected);
          
        }
        public static bool TestGetMin2()
        {
            //arrange
            IArrayVector instance = new ArrayVector(new double[] { 2, 1, 3, 4 });
            double expected = 1;

            //act
            double actual = instance.GetMin();

            //assert
            return actual.Equals(expected);

        }
        public static bool TestGetMin3()
        {
            //arrange
            IArrayVector instance = new ArrayVector(new double[] { 4, 2, 3, 1 });
            double expected = 1;

            //act
            double actual = instance.GetMin();

            //assert
            return actual.Equals(expected);

        }
        public static bool TestMult()
        {
            //arrange
            IArrayVector expected = new ArrayVector(new double[] { 2, 4, 6, 8, 10 });
            IArrayVector actual = new ArrayVector(new double[]{1, 2, 3, 4, 5});

            //act
            actual.Mult(2);
            
            //assert
            return Enumerable.SequenceEqual(expected.Get(), actual.Get());
        }
        public static bool TestGetByIndex1()
        {
            //arrange
            IArrayVector array = new ArrayVector(new double[] { 1, 2, 3, 4 });
            double expected = 1;

            //act
            double actual = array.Get(0);

            //assert
            return actual.Equals(expected);
        }
        public static bool TestGetByIndex2()
        {
            //arrange
            IArrayVector array = new ArrayVector(new double[] { 1, 2, 3, 4 });
            double expected = 2;

            //act
            double actual = array.Get(1);

            //assert
            return actual.Equals(expected);
        }
        public static bool TestGetByIndex3()
        {
            //arrange
            IArrayVector array = new ArrayVector(new double[] { 1, 2, 3, 4 });
            double expected = 4;

            //act
            double actual = array.Get(3);

            //assert
            return actual.Equals(expected);
        }
        public static bool TestGetNorm()
        {
            //arrangde
            IArrayVector instance = new ArrayVector(new double[] { 1, 1, 1, 1, 1 });
            double expected = Math.Sqrt(5);

            //act
            double actual = instance.GetNorm();

            //assert
            return actual.Equals(expected);
        }
        public static bool TestSum()
        {
            //arrange
            IArrayVector currentVector = new ArrayVector(new double[] { 1, 1, 1, 1 });
            IArrayVector anotherVector = new ArrayVector(new double[] { 1, 1, 1 });
            IArrayVector expected = new ArrayVector(new double[] { 2, 2, 2 });

            //act
            IArrayVector actual = currentVector.Sum(anotherVector);

            //assert
            return Enumerable.SequenceEqual(actual.Get(), expected.Get());
        }
        public static bool TestSortAscending()
        {
            //arrange
            IArrayVector actual = new ArrayVector(new double[] { 5, 4, 3, 2, 1 });
            IArrayVector expected = new ArrayVector(new double[] { 1, 2, 3, 4, 5 });

            //act
            actual.SortAscending();

            //assert
            return Enumerable.SequenceEqual(actual.Get(), expected.Get());
        }
        public static bool TestGetSize()
        {
            //arrange
            IArrayVector array = new ArrayVector(new double[] { 9, 9, 9 });
            int expected = 3;

            //act
            int actual = array.GetSize();

            //assert
            return actual.Equals(expected);
        }
        public static bool TestClone1()
        {
            //arrange
            IArrayVector expected = new ArrayVector(new double[] { 1, 2, 3, 4 });

            //act
            IArrayVector actual = expected.Clone();

            //assert
            return Enumerable.SequenceEqual(actual.Get(), expected.Get());
            
        }
        public static bool TestClone2()
        {
            //arrange
            IArrayVector expected = new ArrayVector(new double[] { 1, 2, 3, 4 });
            double[] expected1 = expected.Get();

            //act
            IArrayVector actual = expected.Clone();
            actual.Set(2, 6);

            //assert
            return Enumerable.SequenceEqual(expected.Get(), expected1);

        }
        public static bool TestScalarMult()
        {
            //arrange
            IArrayVector instanse1 = new ArrayVector(new double[] { 2, 2, 2, 2 });
            IArrayVector instanse2 = new ArrayVector(new double[] { 3, 3, 3, 3 });
            double expected = 24;

            //act
            double actual = instanse1.ScalarMult(instanse2);

            //assert
            return actual.Equals(expected);
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(TestScalarMult());
            Console.WriteLine(TestClone2());
            Console.WriteLine(TestGetMin3());
            Console.ReadLine();
        }
    }
}



