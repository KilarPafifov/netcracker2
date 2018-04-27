using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netckacker2;

namespace netcracker2
{
    class ControlFlowStatements1 : IControlFlowStatements1
    {
    
        public double GetFunctionValue(double x)
        {

            if (x > 0)
            {

                return 2 * (Math.Sin(x));
            }
            else
            {
                return 6 - x;
            }
        }

        public int[,] initArray()
        {
            int[,] array = new int[8, 5];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = i * j;
                }
            }
            return array;

        }
        public int getMinValue(int[,] array)
        {

            int minValue = 500;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (minValue > array[i, j])
                    {
                        minValue = array[i, j];
                    }
                }
            }
            return minValue;
        }

        public BankDeposit calculateDeposite(double P)
        {
            BankDeposit obj = new BankDeposit();
            obj.deposit = 1000;
            P /= 100;
            while(obj.deposit <= 5000)
            {
                obj.deposit += obj.deposit * P;
                obj.year += 1;
            }
            return obj;
        }
    }
}