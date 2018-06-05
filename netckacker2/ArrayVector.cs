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

        public void Set(double[] elements)
        {
            vector = elements;   
        }

        public void Set(int index, double value)
        {
            int n = vector.Length;
            if (index >= n)
            {
                n += 1;
                double[] bufArray = new double[n];
                for (int i = 0; i < n - 1; i++)
                {
                    bufArray[i] = vector[i];
                }

                vector = new double[n];
                vector = bufArray;
                vector[n - 1] = value;
            }
            else if(index < n && index >= 0)
            {
                vector[index] = value;
            }
        }

        public double[] Get()
        {
            return vector;
        }

        public double Get(int index)
        {
            if (index < vector.Length)
            {
                return vector[index];
            }
            return -100;
        }

        public double GetMax()
        {
            double max = vector[0];
            for(int i = 0; i < vector.Length; i++)
            {
                if(vector[i] > max)
                {
                    max = vector[i];
                }
            }
            return max;
        }


        public double GetMin()
        {

            double min = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < min)
                {
                    min = vector[i];
                }
            }
            return min;
        }

        public double GetNorm()
        {
            double norma = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                norma += vector[i] * vector[i];
            }
            return Math.Sqrt(norma);
        }

        public int GetSize()
        {
            return vector.Length;
        }


        public ArrayVector clone()
        {
            throw new NotImplementedException();
        }

        public void Mult(double factor)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] *= factor;
            }
        }

        public double ScalarMult(IArrayVector anotherVector)
        {
            int n;
            double scalarMult = 0;
            if(vector.Length > anotherVector.GetSize())
            {
                n = anotherVector.GetSize();
            }
            else
            {
                n = vector.Length;
            }

            double[] another = anotherVector.Get();

            for (int i = 0; i < n; i++) 
            {
                scalarMult += vector[i] * another[i];
            }

            double alfa = 0;

            
            return scalarMult * alfa;
        }

        public void SortAscending()
        {
            for(int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if(vector[i] > vector[j])
                    {
                        vector[i] = vector[j];
                    }
                }
            }
        }

        public IArrayVector klone()
        {
            throw new NotImplementedException();
        }

        public IArrayVector Sum(IArrayVector anotherVector)
        {

            int n;
            double[] sum;
            if (vector.Length > anotherVector.GetSize())
            {
                n = anotherVector.GetSize();
            }
            else
            {
                n = vector.Length;
            }

            double[] another = anotherVector.Get();
            sum = new double[n];

            for (int i = 0; i < n; i++)
            {
                sum[i] = vector[i] + another[i];
            }

            anotherVector.Set(sum);

            return anotherVector;
        }
    }
}
