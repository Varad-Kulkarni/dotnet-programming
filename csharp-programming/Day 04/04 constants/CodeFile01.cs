namespace csharp_programming {
    static class Math {
        public const double PI = 3.14;
    }
    class Program {
        static void Main() {
            double pi = Math.PI;
        }
    }
}

/*
 * C# does not support const methods, properties, or events.
 * Constants are accessed as if they were static fields because
 * the value of the constant is the same for all instances of the type.
 * You do not use the static keyword to declare them.
 */
