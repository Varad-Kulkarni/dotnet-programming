namespace csharp_programming {
    internal class DummyDerived : DummyBase, IDummyInterface, IDummyInterface2 {
        void IDummyInterface.Print() {
            Console.WriteLine("From DummyDerived.Print");
        }

        void IDummyInterface2.Print() {
            Console.WriteLine("From IDummyInterface1.DummyDerived.Print");
        }

        public override void Print() {
            Console.WriteLine("From derived for base");
        }
    }
}

/*
 * C# supports single class inheritance and
 * single or multiple interface inheritance.
 * If class is to be derived from another class and interface(s)
 * then the base class has to be mentioned first and then
 * interface(s).
 */
