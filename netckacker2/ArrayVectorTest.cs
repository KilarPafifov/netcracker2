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
            currentArray.set(expected);
            double[] actual = currentArray.get();


            for (int i = 0; i < 5; i++)
            {
                if(expected[i] != actual[i])
                {
                    return false;
                }
            }
            return true;
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(TestSet());
            Console.ReadLine();
        }
    }
}
