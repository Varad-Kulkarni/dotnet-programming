namespace csharp_programming {
    internal class DummyDerived : IDummyInterface, IDummyInterface2 {
        void IDummyInterface.Print() {
            Console.WriteLine("From DummyDerived.Print");
        }

        void IDummyInterface2.Print() {
            Console.WriteLine("From IDummyInterface1.DummyDerived.Print");
        }
    }
}
