
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netckacker2;

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

        public static bool TestCalculateDeposite()
        {
            //arrange
            ControlFlowStatements1 obj = new ControlFlowStatements1();
            BankDeposit expected = new BankDeposit();
            BankDeposit actual = new BankDeposit();
            expected.deposit = 5062.5;
            expected.year = 4;
            //act
            actual = obj.calculateDeposite(50);
            //assert
            if (expected.year != actual.year)
            {
                return false;
            }
            if (expected.deposit != actual.deposit)
            {
                return false;
            }
            return true;
        }

        public static bool TestEmployee()
        {
            //arrange
            Employee expected = new Employee();
            Employee actual = new Employee();
            Employee manager = new Employee();
            Employee topManager = new Employee();
            topManager.setFirstName("Karl");
            manager.setManager(topManager);
            manager.setFirstName("John");
            manager.setLastName("Johnes");
            expected.setManager(manager);
            expected.setFirstName("Pavel");
            expected.setLastName("Sokolov");
            expected.increaseSalary(500);
            //assert
            if (expected.getFirstName() != "Pavel")
            {
                return false;
            }
            if(expected.getLastName() != "Sokolov")
            {
                return false;
            }
            if(expected.getFullName() != "Pavel Sokolov")
            {
                return false;
            }
            if(expected.getManagerName() != "John")
            {
                return false;
            }
            if(expected.getTopManager() != topManager)
            {
                return false;
            }
            if(expected.getSalary() != 1500)
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TestEmployee());
            Console.ReadLine();
        }
    }
}
