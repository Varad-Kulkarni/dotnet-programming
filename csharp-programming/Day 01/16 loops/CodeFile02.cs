﻿using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            string input;

            Console.Write("Enter integer: ");
            input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            long result = 1;

            int i = 1;
            while (i <= n) {
                result *= i;
                i++;
            }

            Console.WriteLine("Factorial of {0} is {1}", n, result);
        }
    }
}