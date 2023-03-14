namespace csharp_programming {
    static class Algorithm {
        public delegate T Generator<T>();
        public static void Generate<T>(T[] a, Generator<T> gen) {
            int length = a.Length;
            for (int i = 0; i < length; i++) {
                a[i] = gen();
            }
        }
    }

    class EvenNumberGenerator {
        int value = 0;
        public int GetNumber() { // instance method
            int retval = value;
            value += 2;
            return retval;
        }
    }

    class OddNumberGenerator {
        static double value = 1;
        public double GetNumber() { // instance method
            double retval = value;
            value += 2;
            return retval;
        }
    }

    class Program {
        static void Main() {
            int[] a = new int[5];
            double[] a1 = new double[5];
            // method #1
            OddNumberGenerator oddNumberGenerator = new OddNumberGenerator();
            Algorithm.Generator<double> gen = new Algorithm.Generator<double>(oddNumberGenerator.GetNumber);
            Algorithm.Generate(a1, gen);
            // method #2
            EvenNumberGenerator evenNumberGenerator = new EvenNumberGenerator();
            Algorithm.Generate(a, evenNumberGenerator.GetNumber);
        }
    }
}
