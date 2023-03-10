namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            DummyDerived d = new DummyDerived();
        }
    }
}

// The constructor base class is executed first
// The constructor of derived class is executed after base
