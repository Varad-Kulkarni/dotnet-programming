namespace Excercise {
    class Triangle {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC) {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double GetPerimeter() {
            return this.sideA + this.sideB + this.sideC;
        }

        public double GetArea() {
            return Math.Sqrt((GetPerimeter() - this.sideA) * (GetPerimeter() - this.sideB) * (GetPerimeter() - this.sideC));
        }
    }

    class Program {
        public static void Main(string[] args) {
            Triangle triangle = new Triangle(3, 6, 9);
            Console.WriteLine(triangle.GetPerimeter());
            Console.WriteLine(triangle.GetArea());
        }
    }
}