namespace csharp_programming {
    class Program {
        static void Main() {
            string s = null;
            int? length = s?.Length;

            s = "";
            length = s?.Length;
        }
    }
}

// ?. is known as null conditional operator
// it returns null if string is null otherwise length of string