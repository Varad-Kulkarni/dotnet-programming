﻿namespace csharp_programming {
    class Integer {
        public static int value;
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
            i.value = 1;
        }
    }
}

// Static fields cannot be accessed using objects.