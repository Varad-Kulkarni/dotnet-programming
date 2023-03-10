namespace csharp_programming {
    class Math {
        public static int Sum(params int[] n) {
            int result = 0;
            foreach(int t in n)
                result += t;
            return result;
        }
    }
    class Program {
        static void Main() {
            int n = Math.Sum(1, 5);
            n = Math.Sum(1, 5, 7);
        }
    }
}

// static method in C# can be called using class only.
// static method is also called as class method.
// It cannot be called using instance of class.

// Non-static method can be called using instance only.
// Non-static method is also called as instance method.
// It cannot be called using class.