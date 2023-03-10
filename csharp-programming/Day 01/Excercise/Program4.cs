using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Excercise {
    internal class Program4 {
        public static void Main(string[] args) {
            Console.WriteLine("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter elements...");
            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++) {
                arr[i] = Convert.ToInt32(input[i]);
            }

            //for(int i=0; i<n; i++) {
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            for(int i=0; i<n-1; i++) {
                for(int j=i+1; j<n; j++) {
                    if (arr[i] > arr[j]) {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Median of given elements is " + arr[n / 2]);
        }
    }
}
