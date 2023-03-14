using System.Data.Common;
using System.Numerics;

namespace Excercise {
    class Matrix {
        private int row;
        private int col;
        private double[,] matrix;

        public Matrix(int row, int col) {
            this.row = row;
            this.col = col;
            matrix = new double[row, col];
        }

        public double this[int index1, int index2] {
            get { return matrix[index1, index2]; }
            set { matrix[index1, index2] = value; }
        }

        public int GetRow() => this.row;
        public int GetCol() => this.col;

        public static Matrix operator +(Matrix matrix1, Matrix matrix2) {
            if(matrix1.GetRow() != matrix2.GetRow() || matrix1.GetCol() != matrix2.GetCol()) {
                throw new Exception("Invalid operation...");
            }
            
            Matrix matrix = new Matrix(matrix1.GetRow(), matrix2.GetCol());
            for(int i=0; i<matrix.GetRow(); i++) {
                for(int j=0; j<matrix.GetCol(); j++) {
                    matrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2) {
            if (matrix1.GetCol() != matrix2.GetRow()) {
                throw new Exception("Invalid operation...");
            }

            Matrix matrix = new Matrix(matrix1.GetRow(), matrix2.GetCol());
            for (int i = 0; i < matrix1.GetRow(); i++) {
                for (int j = 0; j < matrix2.GetCol(); j++) {
                    double sum = 0.0;
                    for(int k=0; k<matrix1.GetCol(); k++) {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    matrix[i, j] = sum;
                }
            }
            return matrix;
        }
    }

    class Program {
        public static void Main() {
            Matrix m1 = new Matrix(2, 1);
            Matrix m2 = new Matrix(1, 2);
            Matrix m3 = new Matrix(2, 2);

            double temp = 0.0;
            for(int i=0; i<2; i++) {
                for(int j=0; j<1; j++) {
                    m1[i, j] = ++temp;
                }
            }
            for(int i=0; i<1; i++) {
                for(int j=0; j<2; j++) {
                    m2[i, j] = ++temp;
                }
            }
            for(int i=0; i<2; i++) {
                for(int j=0; j<2; j++) {
                    m3[i, j] = ++temp;
                }
            }
            Matrix m4 = m1 * m2;
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(m4[i, j] + " ");
                }
                Console.WriteLine();
            }
            m4 += m3;
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(m4[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}