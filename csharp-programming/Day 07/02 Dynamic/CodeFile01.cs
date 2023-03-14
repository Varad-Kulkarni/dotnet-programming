namespace csharp_programming {
    class Dummy { }

    class Program {
        public static void Main() {
            dynamic dummy = new Dummy();
            dummy.Foo();
        }
    }
}

// C# 4 introduce a new type called dynamic
// 'dynamic' is kind of late binding in C#
// dynamic refers member call resolution to runtime rather than the compile time