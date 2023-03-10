using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program6 {
        public static int LargestGap(int[] a) {
            int n = a.Length;

            for(int i=0; i<n-1; i++) {
                for(int j=i+1; j<n; j++) {
                    if (a[i] > a[j]) {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            int ans = 0;
            for(int i=0; i<n-1; i++) {
                if (a[i+1] - a[i] > ans) {
                    ans = a[i + 1] - a[i];
                }
            }
            return ans;
        }

        public static void Main(string[] args) {
            int[] a = { 9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5 };
            Console.WriteLine("Largest gap of array is " + LargestGap(a));
        }
    }
}
