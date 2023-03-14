namespace csharp_programming {
    class Program {
        static double SafeDivision(double n1, double n2) {
            if(n2 == 0) {
                throw new DivideByZeroException();
            }
            return n1 / n2;
        }

        public static void Main(string[] args) {
            double a = 9.0, b = 0.0, c = 0.0;

            try {
                c = SafeDivision(a, b);
                Console.WriteLine(c);
            }
            catch(DivideByZeroException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}