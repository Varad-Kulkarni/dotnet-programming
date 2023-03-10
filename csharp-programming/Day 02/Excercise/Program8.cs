using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program8 {
        static int BinarySearch(int[] a, int target) {
            int i = 0,j = a.Length - 1;

            while(i <= j) {
                int mid = i + (j - i) / 2;
                if (a[mid] == target) {
                    return mid;
                }
                else if (a[mid] < target) {
                    i = mid + 1;
                }
                else {
                    j = mid - 1;
                }
            }

            return -1;
        } 
        public static void Main(string[] args) {
            int n = 7;
            int[] a = new int[n];
            for(int i=0; i<n; i++) {
                a[i] = i;
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(BinarySearch(a, 0));
            Console.WriteLine(BinarySearch(a, 1));
            Console.WriteLine(BinarySearch(a, 2));
            Console.WriteLine(BinarySearch(a, 3));
            Console.WriteLine(BinarySearch(a, 4));
            Console.WriteLine(BinarySearch(a, 5));
            Console.WriteLine(BinarySearch(a, 6));
            Console.WriteLine(BinarySearch(a, 7));
            Console.WriteLine(BinarySearch(a, 8));
        }
    }
}
