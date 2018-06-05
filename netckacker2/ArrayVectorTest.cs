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
            double[] expected = new double[5];
            for(int i = 0; i < 5; i++)
            {
                expected[i] = i + 3;
            }
            IArrayVector currentArray = new ArrayVector();
            currentArray.Set(expected);
            double[] actual = currentArray.Get();


            for (int i = 0; i < 5; i++)
            {
                if(expected[i] != actual[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool TestSetByIndex()
        {
            double elem = 4.5;
            double[] mas = new double[4];
            for(int i = 0; i < 4; i++)
            {
                mas[i] = i + 2;
            }
            IArrayVector expected = new ArrayVector();
            expected.Set(mas);
            double[] actual = new double[5];
            for (int i = 0; i < 4; i++)
            {
                actual[i] = i + 2;
            }
            actual[4] = elem;
            expected.Set(4, elem);
            for (int i = 0; i < 5; i++)
            {
                if (expected.Get()[i] != actual[i])
                {
                    return false;
                }
            }
            return true;
        }
        
        public static bool TestGetMax()
        {
            IArrayVector expected = new ArrayVector();
            double[] mas = new double[4];

            for (int i = 0; i < 4; i++)
            {
                mas[i] = i;
            }

            expected.Set(mas);

            mas[0] += 10;
            if(expected.GetMax() != mas[0])
            {
                return false;
            }

            mas[1] += 10;
            if (expected.GetMax() != mas[1])
            {
                return false;
            }

            mas[2] += 10;
            if (expected.GetMax() != mas[2])
            {
                return false;
            }

            mas[3] += 10;
            if (expected.GetMax() != mas[3])
            {
                return false;
            }

            return true;
        }

        public static bool TestGetMin()
        {
            IArrayVector expected = new ArrayVector();
            double[] mas = new double[4];

            for (int i = 0; i < 4; i++)
            {
                mas[i] = i;
            }

            expected.Set(mas);

            mas[3] -= 10;
            if (expected.GetMin() != mas[3])
            {
                return false;
            }

            mas[2] -= 10;
            if (expected.GetMin() != mas[2])
            {
                return false;
            }

            mas[1] -= 10;
            if (expected.GetMin() != mas[1])
            {
                return false;
            }

            mas[0] -= 10;
            if (expected.GetMin() != mas[0])
            {
                return false;
            }

            return true;
        }

        public static bool TestMult()
        {
            IArrayVector array = new ArrayVector();
            double[] mas = new double[4];
            int factor = 2;

            for (int i = 0; i < 4; i++)
            {
                mas[i] = i;
            }

            array.Set(mas);
            array.Mult(factor);
            double[] expected = array.Get();

            double[] actual = new double[4];

            for (int i = 0; i < 4; i++)
            {
                actual[i] = i * factor;
            }

            for(int i = 0; i < 4; i++)
            {
                if(actual[i] != expected[i])
                {
                    return false;
                }
            }

            return true;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(TestMult());
            Console.ReadLine();
        }
    }
}
