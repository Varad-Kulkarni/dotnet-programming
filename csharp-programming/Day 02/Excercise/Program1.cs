using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program1 {
        static int CalculateArea(int width = 1, int height = 1) {
            return width * height;
        }
        public static void Main(string[] args) {
            Console.WriteLine("Area is: " + CalculateArea());
            Console.WriteLine("Area is: " + CalculateArea(3));
            Console.WriteLine("Area is: " + CalculateArea(3, 6));
        }
    }
}
