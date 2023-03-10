namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            IDummyInterface b = new DummyDerived();
            b.HelloProperty = "Hello";
            Console.WriteLine(b.HelloProperty);
            b.Print();
        }
    }
}
