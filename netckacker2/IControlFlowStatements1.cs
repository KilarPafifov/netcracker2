using System;
using System.Collections.Generic;
using System.Linq;
using netckacker2;
using System.Text;
using System.Threading.Tasks;

namespace netcracker2
{
    public interface IControlFlowStatements1
    {
        double GetFunctionValue(double x);
        int[,] initArray();
        int getMinValue(int[,] array);

        BankDeposit calculateDeposite(double P);
    }
}
