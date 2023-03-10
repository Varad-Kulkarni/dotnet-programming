using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program4 {
        static int Area(int width, int height) {
            return width * height;
        }

        static int Area(int length) {
            return length * length;
        }

        public static void Main(string[] args) {
            Console.WriteLine("Area of rectangle of width 3 units and height 6 units is " + Area(3, 6) + " units");
            Console.WriteLine("Area of square of length 3 units is " + Area(3) + " units");
        }
    }
}
