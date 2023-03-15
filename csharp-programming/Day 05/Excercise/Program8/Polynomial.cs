namespace Excercise {
    abstract class Polynomial {
        protected double[] Coefficients;

        public abstract void AddCoefficient();
        public abstract double Evaluate(int x);
        public abstract double Derivative(int x);
    }
}