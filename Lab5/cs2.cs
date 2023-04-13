using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Matrix
    {
        private int[,] _data;
        public int Rows { get { return _data.GetLength(0); } }
        public int Cols { get { return _data.GetLength(1); } }
        public int this[int row, int col]
        {
            get { return _data[row, col]; }
            set { _data[row, col] = value; }
        }

        public Matrix(int rows, int cols)
        {
            _data = new int[rows, cols];
        }

        public Matrix(int[,] data)
        {
            _data = data;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
                throw new ArgumentException("Matrix sizes must match.");

            Matrix result = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Cols != b.Cols)
                throw new ArgumentException("Matrix sizes must match.");

            Matrix result = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Cols != b.Rows)
                throw new ArgumentException("Invalid matrix sizes for multiplication.");

            Matrix result = new Matrix(a.Rows, b.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Cols; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.Cols; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix a, int scalar)
        {
            Matrix result = new Matrix(a.Rows, a.Cols);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    result[i, j] = a[i, j] * scalar;
                }
            }
            return result;
        }


        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            if (a.Rows != b.Rows || a.Cols != b.Cols)
                return false;

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Cols; j++)
                {
                    if (a[i, j] != b[i, j])
                        return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Matrix other = (Matrix)obj;

            if (Rows != other.Rows || Cols != other.Cols)
                return false;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (this[i, j] != other[i, j])
                        return false;
                }
            }

            return true;
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    result += this[i, j] + ",";
                }
                result += "\n";
            }
            return result;
        }

    }


    internal class cs2
    {
        public static void task_2()
        {
            int[,] matrix1 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value for matrix1[{i},{j}]: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] matrix2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value for matrix2[{i},{j}]: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Matrix a = new Matrix(matrix1);
            Matrix b = new Matrix(matrix2);

            // Виклик перевантаження додавання
            Matrix sum = a + b;
            Console.WriteLine("Sum of matrices:");
            Console.WriteLine(sum.ToString());

            // Виклик перевантаження віднімання
            Matrix difference = a - b;
            Console.WriteLine("Difference of matrices:");
            Console.WriteLine(difference.ToString());

            // Виклик перевантаження множення
            Matrix product = a * b;
            Console.WriteLine("Product of matrices:");
            Console.WriteLine(product.ToString());

            // Виклик перевантаження множення матриці на число
            Matrix scalarProduct = a * 2;
            Console.WriteLine("Scalar product of matrix a:");
            Console.WriteLine(scalarProduct.ToString());

            // Виклик перевантаження порівняння на рівність
            if (a == b)
            {
                Console.WriteLine("Matrices are equal");
            }
            else
            {
                Console.WriteLine("Matrices are not equal");
            }

            // Виклик перевантаження порівняння на нерівність
            if (a != b)
            {
                Console.WriteLine("Matrices are not equal");
            }
            else
            {
                Console.WriteLine("Matrices are equal");
            }
        }

    }
}
