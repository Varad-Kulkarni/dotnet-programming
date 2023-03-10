namespace Excercise {
    class Matrix {
        private int[,] matrix;

        public Matrix(int row, int col) {
            matrix = new int[row, col];
        }

        public int this[int rowIndex, int colIndex] {
            get { return matrix[rowIndex, colIndex]; }
            set { matrix[rowIndex, colIndex] = value; }
        }

        public void Transpose() {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for(int i=0; i<row; i++) {
                for(int j=0; j<col; j++) {
                    if(i < j && i < col && j < row) {
                        int temp = this[i, j];
                        this[i, j] = this[j, i];
                        this[j, i] = temp;
                    }
                }
            }
        }

        public void Transpose(int[,] transpose) {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    transpose[j, i] = this[i, j];
                }
            }
        }

        public void PrintMatrix() {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            for (int i=0; i<row; i++) {
                for(int j=0; j<col; j++) {
                    Console.Write(this[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void PrintMatrix(int[,] mat) {
            int row = mat.GetLength(0);
            int col = mat.GetLength(1);
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter number of rows in matrix: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of rows in matrix: ");
            int col = Convert.ToInt32(Console.ReadLine());

            Matrix matrix = new Matrix(row, col);
            Console.WriteLine("Enter the values according to index given below...");

            for(int i=0; i<row; i++) {
                for(int j=0; j<col; j++) {
                    Console.WriteLine("Enter value of index (" + i + ", " + j + "): ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            matrix.PrintMatrix();
            int[,] transpose = new int[col, row];
            matrix.Transpose(transpose);
            Console.WriteLine("Printing transpose of matrix...");
            matrix.PrintMatrix(transpose); 
        }
    }
}