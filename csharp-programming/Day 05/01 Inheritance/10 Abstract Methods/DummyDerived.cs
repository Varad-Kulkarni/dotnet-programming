﻿namespace csharp_programming {
    internal class DummyDerived : DummyBase {
        public override void Print() {
            Console.WriteLine("From Derived.Print");
        }
    }
}
