namespace csharp_programming {
    class Program {
        static void Main() {
            string s = null;
            int? length = s?.Length ?? 0;

            s = "";
            length = s?.Length ?? 0;
        }
    }
}

// Null coalescing operator is used with null operator to ensure always is number
// Note length is no more nullable type variable