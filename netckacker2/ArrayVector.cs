using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    class ArrayVector : IArrayVector
    {
        private double[] vector;


        public void set(double[] elements)
        {
            if (elements != null)
            {
                vector = new double[elements.Length];
                for (int i = 0; i < elements.Length; i++)
                {
                    vector[i] = elements[i];
                }
            }
        }

        public void set(int index, double value)
        {
            throw new NotImplementedException();
        }

        public double[] get()
        {
            return vector;
        }

        public double get(int index)
        {
            throw new NotImplementedException();
        }

        public double getMax()
        {
            throw new NotImplementedException();
        }

        public double getMin()
        {
            throw new NotImplementedException();
        }

        public double getNorm()
        {
            throw new NotImplementedException();
        }

        public int getSize()
        {
            throw new NotImplementedException();
        }


        public ArrayVector clone()
        {
            throw new NotImplementedException();
        }

        public void mult(double factor)
        {
            throw new NotImplementedException();
        }

        public double scalarMult(ArrayVector anotherVector)
        {
            throw new NotImplementedException();
        }

        public void sortAscending()
        {
            throw new NotImplementedException();
        }

        public ArrayVector sum(ArrayVector anotherVector)
        {
            throw new NotImplementedException();
        }
    }
}
