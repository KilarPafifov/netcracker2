using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcracker2
{
    class ControlFlowStatements1Test
    {
        public static bool TestGetFunctionValue()
        {
            ControlFlowStatements1 test = new ControlFlowStatements1();
            if (Math.Round(test.GetFunctionValue(2), 1) != 1.8)
            {
                return false;
            }

            if (test.GetFunctionValue(0) != 6)
            {
                return false;
            }

            if (test.GetFunctionValue(-2) != 8)
            {
                return false;
            }

            return true;
        }

        public static bool TestInitArray()
        {
            //arrange
            ControlFlowStatements1 mas = new ControlFlowStatements1();
            int[,] expectedArray = { { 0, 0, 0, 0, 0 }, { 0, 1, 2, 3, 4 } };
            //act
            int[,] actualArray = mas.initArray();
            //assert
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (expectedArray[i, j] != actualArray[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;

        }
        public static bool TestGetMinValue()
        {
            //arrange
            ControlFlowStatements1 minValue = new ControlFlowStatements1();
            int expectedValue = 0;
            //act
            //assert
            if (expectedValue != minValue.getMinValue(minValue.initArray()))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static void Main(string[] args)
        { 
            Console.WriteLine(8);
            Console.ReadLine();
        }
    }
}
