namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            DummyBase b = new DummyDerived();
            b.Print();
        }
    }
}


// Sealed class cannot be derived further
// Sealed class cannot have virtual functions