using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program7 {
        public static void Main(string[] args) {
            int[,] a1 = new int[3, 2];
            int[,] a2 = new int[2, 3];

            Console.WriteLine("First matrix is...");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 2; j++) {
                    a1[i, j] = i + j;
                    Console.Write(a1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Second matrix is...");
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 3; j++) {
                    a2[i, j] = i - j;
                    Console.Write(a2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Printing the multiplied matrix...");
            for(int i=0; i<3; i++) {
                for(int j=0; j<3; j++) {
                    int temp = 0;
                    for(int k=0; k<2; k++) {
                        temp += a1[i, k] * a2[k, j];
                    }
                    Console.Write(temp + " ");
                }
                Console.WriteLine();
            }
        } 
    }
}
