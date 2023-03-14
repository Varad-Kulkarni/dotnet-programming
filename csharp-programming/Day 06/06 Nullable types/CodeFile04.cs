namespace csharp_programming {
    class Program {
        static void Main() {
            int? i = null;
            int? j = 10;
            bool result = i.HasValue;
            result = j.HasValue;
        }
    }
}

// HasValue indicated if nullable type object has underlying value or not
// return true if has
// return false if not