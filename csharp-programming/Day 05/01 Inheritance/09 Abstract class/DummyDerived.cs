﻿namespace csharp_programming {
    internal class DummyDerived : DummyBase {
        public override void Print() {
            base.Print();
            Console.WriteLine("From Derived.Print");
        }
    }
}
