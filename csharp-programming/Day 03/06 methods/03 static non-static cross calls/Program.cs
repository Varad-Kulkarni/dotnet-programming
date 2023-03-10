using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_03._06_methods._03_static_non_static_cross_calls {
    internal class Program {
        public void F() { }
        public static void G() { }
        public void K() {
            F();
            G();
        }
        public static void H() {
            F();
            G();
        }
    }
}

// A non static member can access static and non static member.
// A non-static member can access only static members.
