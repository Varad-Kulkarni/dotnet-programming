namespace Excercise {
    class Program {
        public static void Main() {
            Polynomial quadratic = new QuadraticPolynomial();
            quadratic.AddCoefficient();
            Console.WriteLine("f(3) = " + quadratic.Evaluate(3));
            Console.WriteLine("f'(3) = " + quadratic.Derivative(3));

            Polynomial cubic = new CubicPolynomial();
            cubic.AddCoefficient();
            Console.WriteLine("f(3) = " + cubic.Evaluate(3));
            Console.WriteLine("f'(3) = " + cubic.Derivative(3));
        }
    }
}