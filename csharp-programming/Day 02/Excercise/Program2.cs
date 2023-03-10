using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program2 {
        static int Fibonacci(int n) {
            if (n == 0 || n == 1) {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static void Main(string[] args) {
            Console.WriteLine("Enter the 'n' for nth number in fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + "th fibonacci number is " + Fibonacci(n));
        }
    }
}
