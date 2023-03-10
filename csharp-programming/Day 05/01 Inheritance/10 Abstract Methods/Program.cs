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
            DummyBase b = new DummyDerived();
            b.Print();
        }
    }
}

// Abstract methods cannot have body
// Abstract method cannot be member of non-abstract class
// Abstract base member cannot be called
