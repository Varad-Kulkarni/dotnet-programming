namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            using DummyBase d = new DummyDerived();
        }
    }
}
