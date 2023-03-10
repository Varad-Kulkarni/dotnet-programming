using System.Diagnostics;

namespace Excercise {
    class Triangle {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public Triangle(int a, int b, int c) {
            Side1 = a;
            Side2 = b;
            Side3 = c;
        }

        public int this[string str] {
            get {
                if(str == "a") {
                    return Side1;
                }
                if(str == "b") {
                    return Side2;
                }
                return Side3;
            }
        }

        public double Area() {
            double result = 0.0;

            double s = (this["a"] + this["b"] + this["c"]) / 2;
            result = (double)(s * (s - (double)this["a"]) * (s - (double)this["b"]) * (s - (double)this["c"]));
            result = Math.Sqrt(result);
            return result;
        }
    }
    class Program {
        public static void Main(string[] args) {
            Triangle t = new Triangle(3, 4, 5);
            Debug.Assert(t["a"] == 3);
            Debug.Assert(t["b"] == 4);
            Debug.Assert(t["c"] == 5);
            double result = t.Area();
            Debug.Assert(result == 6.0);
        }
    }

}