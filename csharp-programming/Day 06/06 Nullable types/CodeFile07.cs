namespace csharp_programming {
    class Program {
        static void Main() {
            int? i = 5;
            int? j = i * 5 ?? 5;
            i = null;
            j = i * 5 ?? 5;
        }
    }
}

// ?? is known as null coalescing operator
// a ?? b (if a is null then b or a)