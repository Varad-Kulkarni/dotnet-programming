namespace Excercise {
    static class Calculator {
        public delegate double MathOperation(double num1, double num2);
        public static double Calculate(double num1, double num2, MathOperation op) => op(num1, num2);
    }

    class Math_Dummy {
        public static double Add(double num1, double num2) => (num1 + num2);

        public static double Substract(double num1, double num2) => (num1 - num2);

        public static double Multiply(double num1, double num2) => (num1 * num2);

        public static double Divide(double num1, double num2) => num1 / num2;
    }

    class Program {
        public static void Main(string[] args) {
            double num1 = 9.0;
            double num2 = 2.0;

            Console.WriteLine(Calculator.Calculate(num1, num2, Math_Dummy.Add));
            Console.WriteLine(Calculator.Calculate(num1, num2, Math_Dummy.Substract));
            Console.WriteLine(Calculator.Calculate(num1, num2, Math_Dummy.Multiply));
            Console.WriteLine(Calculator.Calculate(num1, num2, Math_Dummy.Divide));
        }
    }
}