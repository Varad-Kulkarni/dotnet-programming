﻿namespace csharp_programming {
    struct Integer {
        public int value;
    }
    class Program {
        static void Main() {
            Integer i; // value type variables can be used without calling new operator
            i.value = 1;
            int n = i.value;
        }
    }
}

// When we define a class then it results in reference type whereas in the struct it is value type.