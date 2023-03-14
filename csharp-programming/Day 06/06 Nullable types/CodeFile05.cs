namespace csharp_programming {
    class Program {
        static void Main() {
            int? i = 5;
            int? j = i * 5;
            int k = j.Value;
        }
    }
}

// Operations on nullable values
// Use property Value to assign nullable object value to non-nullable variables