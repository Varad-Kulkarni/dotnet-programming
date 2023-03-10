using System;

namespace csharp_programming {
    class Program {
        static void Main() {
            string input;

            Console.Write("Enter first integer: ");
            input = Console.ReadLine();
            int a = Convert.ToInt32(input);

            Console.Write("Enter second integer: ");
            input = Console.ReadLine();
            int b = Convert.ToInt32(input);

            Console.Write("Enter third integer: ");
            input = Console.ReadLine();
            int c = Convert.ToInt32(input);

            int max = 0;

            if (a > b) {
                if (a > c) {
                    max = a;
                }
                else {
                    max = c;
                }
            }
            else {
                if (b > c)
                    max = b;
                else
                    max = c;
            }

            Console.WriteLine("{0} is the maximum integer.", max);
        }
    }
}

//Fallthrough can be happens from one case to anathor case if they have nothing.
// e.g. 

//{
//    switch (Case) {
//        case 1:
//        //some code
//                       <-----error(break required)
//        case 2:
//            //some code
//    }

//    switch (Case) {
//        case 1:
//        case 2:      <------No code that is why no error
//    }
//}

// Default always contain break statement.
// Default can be located anywhere in the switch cases. I executes when no matching case is found.