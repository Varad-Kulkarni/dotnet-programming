namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            DummyBase b2 = new DummyDerived();
            b2.Print();

            IDummyInterface b = new DummyDerived();
            b.Print();

            IDummyInterface2 b1 = new DummyDerived();
            b1.Print();
        }
    }
}
