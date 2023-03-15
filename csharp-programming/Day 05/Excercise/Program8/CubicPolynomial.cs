namespace Excercise {
    class CubicPolynomial : Polynomial {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public CubicPolynomial() {
            base.Coefficients = new double[4];
        }

        public override void AddCoefficient() {
            Console.WriteLine("Enter Coefficients for quadratic...");
            for (int i=0; i<4; i++) {
                Console.WriteLine("Enter coefficient for x^" + i);
                base.Coefficients[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("f(x) = {3}x^3 + {2}x^2 + {1}x + {0}", Coefficients[0], Coefficients[1], Coefficients[2], Coefficients[3]);
            A = Coefficients[0];
            B = Coefficients[1];
            C = Coefficients[2];
            D = Coefficients[3];
        }

        public override double Evaluate(int x) {
            double result = 0.0;
            for (int i = 0; i < 4; i++) {
                result += base.Coefficients[i] * Math.Pow(x, i);
            }
            return result;
        }

        public override double Derivative(int x) {
            return Coefficients[3] * 3 * x * x + Coefficients[2] * 2 * x + Coefficients[1];
        }
    }
}