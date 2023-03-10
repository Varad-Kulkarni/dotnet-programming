using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.Excercise {
    internal class Program10 {
        public static bool Cons(int[] a) {
            Array.Sort(a);
            for(int i=0; i<a.Length-1; i++) {
                if (a[i+1] - a[i] != 1) {
                    return false;
                }
            }
            return true;
        }

        public static void Main(string[] args) {
            Console.WriteLine(Cons(new int[] { 5, 1, 4, 3, 2 }));
            Console.WriteLine(Cons(new int[] { 5, 1, 4, 3, 2, 8 }));
            Console.WriteLine(Cons(new int[] { 5, 6, 7, 8, 9, 9 }));
        }
    }
}
