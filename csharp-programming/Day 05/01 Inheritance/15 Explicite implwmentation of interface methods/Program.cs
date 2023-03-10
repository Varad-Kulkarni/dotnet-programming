namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            IDummyInterface b = new DummyDerived();
            b.Print();

            IDummyInterface2 b1 = new DummyDerived();
            b1.Print();
        }
    }
}
