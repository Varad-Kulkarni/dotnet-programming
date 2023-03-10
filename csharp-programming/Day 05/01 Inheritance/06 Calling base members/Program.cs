namespace csharp_programming {
    class A {
        public virtual void F() { }
    }

    class B : A {
        public override void F() {
            base.F();
        }
    }

    class C : B {
        public override void F() {
            base.F();
        }
    }

    internal class Program {
        public static void Main(string[] args) {
            DummyBase d = new DummyDerived();
            d.Print();

            DummyDerived derived = new DummyDerived();
            derived.Print();
        }
    }
}
