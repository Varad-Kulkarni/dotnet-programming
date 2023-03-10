using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program9 {
        public static bool IsThereConsecutive(int[] a, int n, int times) {
            int freq = 0;
            for(int i=0; i<a.Length; i++) {
                if (a[i] == n) {
                    ++freq;
                }
            } 
            if(freq == times) {
                return true;
            }
            return false;
        }

        public static void Main(string[] args) {
            Console.WriteLine(IsThereConsecutive(new int[] { 1, 2, 3, 4, 5 }, 1, 1));
            Console.WriteLine(IsThereConsecutive(new int[] { 3 }, 1, 0));
            Console.WriteLine(IsThereConsecutive(new int[] { 2, 2, 3, 2, 2, 2, 2, 3, 4, 1, 5 }, 3, 2));
            Console.WriteLine(IsThereConsecutive(new int[] { 5, 5, 5, 5, 5 }, 5, 7));
        }
    }
}
