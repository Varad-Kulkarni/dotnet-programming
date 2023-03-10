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
            DummyBase b = new DummyBase();
            b.Print();

            DummyDerived derived = new DummyDerived();
            derived.Print();
        }
    }
}

// Abstract class cannot be instantiated...
// It is not possible to create object of dummy base...
