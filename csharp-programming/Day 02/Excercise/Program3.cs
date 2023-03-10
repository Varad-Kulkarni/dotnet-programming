using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program3 {
        static int GCD(int a, int b) {
            if(b == 0) {
                return a;
            }
            return GCD(b, a % b);
        }
        public static void Main(string[] args) {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("GCD of " + num1 + " and " + num2 + " is " + GCD(num1, num2));
        }
    }
}
