using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MatrixClass
{
    public class Matrix<T>
    {
        // 08.Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        public int Row
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Col
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        //09.Implement an indexer this[row, col] to access the inner matrix cells.

        public T this[int row, int col]
        {
            get
            {
                if (row<0 || row>=this.matrix.GetLength(0) || col <0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index is out of range !");
                }
                return this.matrix[row, col];
            }

            set 
            {
                if (row < 0 || row >= this.matrix.GetLength(0) || col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index is out of range !");
                }

                this.matrix[row, col] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrix.GetLength(1); j++)
                {
                    sb.Append(this.matrix[i, j] + " " + "|");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
        /* 10.Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
         Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).*/
        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne == null || matrixTwo == null)
            {
                throw new ArgumentNullException("There is null matrix !");
            }
            if (matrixOne.Row != matrixTwo.Row || matrixOne.Col != matrixTwo.Col)
            {
                throw new ArgumentException("Different dimensions detected!");
            }
            Matrix<T> result = new Matrix<T>(matrixOne.Row, matrixOne.Col);

            for (int i = 0; i < matrixOne.Row; i++)
            {
                for (int j = 0; j < matrixOne.Col; j++)
                {
                    result[i, j] = (dynamic)matrixOne[i, j] + (dynamic)matrixTwo[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne == null || matrixTwo == null)
            {
                throw new ArgumentNullException("There is null matrix !");
            }
            if (matrixOne.Row != matrixTwo.Row || matrixOne.Col != matrixTwo.Col)
            {
                throw new ArgumentException("Different dimensions detected!");
            }
            Matrix<T> result = new Matrix<T>(matrixOne.Row, matrixOne.Col);

            for (int i = 0; i < matrixOne.Row; i++)
            {
                for (int j = 0; j < matrixOne.Col; j++)
                {
                    result[i, j] = (dynamic)matrixOne[i, j] - (dynamic)matrixTwo[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne == null || matrixTwo == null)
            {
                throw new ArgumentNullException("There is null matrix !");
            }
            if (matrixOne.Row != matrixTwo.Col)
            {
                throw new ArgumentException("MatrixOne rows and MatrixTwo columns must be equal!");
            }
            Matrix<T> result = new Matrix<T>(matrixOne.Row, matrixTwo.Col);

            for (int row = 0; row < matrixOne.Row; row++)
            {
                for (int col = 0; col < matrixTwo.Col; col++)
                {
                    dynamic temp = 0;
                    for (int currentnumbers = 0; currentnumbers < matrixOne.Col; currentnumbers++)
                    {
                        temp = temp + (dynamic)matrixOne[row, currentnumbers] * (dynamic)matrixTwo[currentnumbers, col];
                    }
                    result[row, col] = temp;
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T> matrixOne)
        {
            for (int row = 0; row < matrixOne.Row; row++)
            {
                for (int col = 0; col < matrixOne.Col; col++)
                {
                    if (matrixOne[row, col] != (dynamic)0 )
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator false(Matrix<T> matrixOne)
        {
            for (int row = 0; row < matrixOne.Row; row++)
            {
                for (int col = 0; col < matrixOne.Col; col++)
                {
                    if (matrixOne[row, col] != (dynamic)0 )
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
