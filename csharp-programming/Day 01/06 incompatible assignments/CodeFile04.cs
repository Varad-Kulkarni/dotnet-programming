﻿namespace csharp_programming {
    class Program {
        static void Main() {
            string s = "3.14";
            double d = double.Parse(s);
            int i = int.Parse(s);
        }
    }
}

/*
 * - If string is not in valid form, Parse throws FormatException.
 */
