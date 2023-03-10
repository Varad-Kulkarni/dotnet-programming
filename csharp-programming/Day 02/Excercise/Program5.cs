using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program5 {
        static int[] ArrayOfMultiples(int start, int length) {
            int[] a = new int[length];
            int temp = start;

            for(int i=0; i<length; i++) {
                a[i] = temp;
                temp += start;
            }

            return a;
        }

        public static void Main(string[] args) {
            Console.WriteLine("Enter the multiple for array: ");
            int multiple = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length for array: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Printing the array...");
            int[] a = ArrayOfMultiples(multiple, length);
            for(int i=0; i<a.Length; i++) {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
