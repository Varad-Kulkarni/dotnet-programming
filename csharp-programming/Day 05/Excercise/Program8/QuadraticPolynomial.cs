namespace Excercise {
    class QuadraticPolynomial : Polynomial {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public QuadraticPolynomial() {
            base.Coefficients = new double[3];
        }

        public override void AddCoefficient() {
            Console.WriteLine("Enter Coefficients for quadratic...");
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Enter coefficient for x^" + i);
                base.Coefficients[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("f(x) = {2}x^2 + {1}x + {0}", Coefficients[0], Coefficients[1], Coefficients[2]);
            A = Coefficients[0];
            B = Coefficients[1];
            C = Coefficients[2];
        }

        public override double Evaluate(int x) {
            double result = 0.0;
            for(int i=0; i<3; i++) {
                result += base.Coefficients[i] * Math.Pow(x, i);
            }
            return result;
        }

        public override double Derivative(int x) {
            return Coefficients[2] * 2 * x + Coefficients[1];
        }
    }
}