using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Excercise {
    internal class Program8 {
        static int CountOnes(int n) {
            int count = 0;
            while(n > 0) {
                if(n % 2 == 0) {
                    n = n / 2;
                }
                else {
                    count++;
                    n = (n-1) / 2;
                }
            }
            return count;
        }

        public static void Main(string[] args) {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of ones in binary representation of " + num + " is " + CountOnes(num));
        }
    }
}
