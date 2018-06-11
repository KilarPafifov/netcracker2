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
        public ArrayVector(){}
        public ArrayVector(double[] elements)
        {
            vector = elements;
        }
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
            if(index < 0 || index >= vector.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return vector[index];
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
        public IArrayVector Clone()
        {
            IArrayVector copy = new ArrayVector();
            double[] copyVector = new double[vector.Length];
            Array.Copy(vector, copyVector, vector.Length);
            copy.Set(copyVector);
            return copy;
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
           
            if(vector.Length > anotherVector.GetSize())
            {
                n = anotherVector.GetSize();
            }
            else
            {
                n = vector.Length;
            }

            double[] another = anotherVector.Get();
            double scalarMult = 0;

            for (int i = 0; i < n; i++) 
            {
                scalarMult += vector[i] * another[i];
            }

            return scalarMult;
        }
        public void SortAscending()
        {
            double buffer = 0;
            for(int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if(vector[i] > vector[j])
                    {
                        buffer = vector[i];
                        vector[i] = vector[j];
                        vector[j] = buffer;
                    }
                }
            }
        }
        public IArrayVector Sum(IArrayVector anotherVector)
        {

            int n;
            if (vector.Length > anotherVector.GetSize())
            {
                n = anotherVector.GetSize();
            }
            else
            {
                n = vector.Length;
            }

            double[] another = anotherVector.Get();
            double[] sum = new double[n];

            for (int i = 0; i < n; i++)
            {
                sum[i] = vector[i] + another[i];
            }

            anotherVector.Set(sum);

            return anotherVector;
        }
    }
}
