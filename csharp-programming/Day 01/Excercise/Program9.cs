using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Excercise {
    internal class Program9 {
        static string SortDescending(string str) {
            int n = str.Length;
            char[] a = new char[n];
            for(int i=0; i<n; i++) {
                a[i] = str[i];
            }
            for(int i=0; i<a.Length-1; i++) {
                for(int j=i+1; j<a.Length; j++) {
                    int temp1 = Convert.ToInt32(a[i]);
                    int temp2 = Convert.ToInt32(a[j]);

                    if(temp1 < temp2) {
                        var temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            string ans = "";
            for(int i=0; i<a.Length; i++) {
                ans += a[i];
            }
            return ans;
        }

        public static void Main(string[] args) {
            Console.WriteLine("Enter number of testcases: ");
            int testcases = Convert.ToInt32(Console.ReadLine());
            while(testcases-- > 0) {
                Console.WriteLine("Enter the number to get its descending form...");
                Console.WriteLine("Sorted form of number is " + SortDescending(Console.ReadLine()));
            }
        }
    }
}
