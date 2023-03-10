using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Excercise {
    internal class Program7 {
        static int[] HighLow(string s) {
            int high = int.MinValue, low = int.MaxValue;

            string[] a = s.Split(' ');
            for(int i=0; i<a.Length; i++) {
                int temp = Convert.ToInt32(a[i]);
                if(temp > high) {
                    high = temp;
                }
                if(temp < low) {
                    low = temp;
                }
            }
            return new int[] { low, high };
        }

        public static void Main(string[] args) {
            Console.WriteLine("Enter the number of lines you have to enter...");
            int n = Convert.ToInt32(Console.ReadLine());

            while(n-- > 0) {
                Console.WriteLine("Enter elements...");
                int[] temp = HighLow(Console.ReadLine());
                Console.WriteLine("Lowest of given elements is " + temp[0] + " & highest is " + temp[1]);
            }
        }
    }
}
