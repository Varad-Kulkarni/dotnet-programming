using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Excercise {
    internal class Program5 {
        public static void Main(string[] args) {
            Console.WriteLine("Enter currency unit number ");
            Console.WriteLine("1. INR (India)");
            Console.WriteLine("2. USD (United States)");
            int unit1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter currency unit number in which you want to convert ");
            Console.WriteLine("1. INR (India)");
            Console.WriteLine("2. USD (United States)");
            int unit2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter amount");
            double amount = Convert.ToDouble(Console.ReadLine());

            switch(unit1) {
                case 1:
                    switch(unit2) {
                        case 1:
                            Console.WriteLine("Enter different unit...");
                            break;
                        case 2:
                            Console.WriteLine(amount * 80);
                            break;
                    }
                    break;

                case 2:
                    switch (unit2) {
                        case 1:
                            Console.WriteLine(amount / 80);
                            break;
                        case 2:
                            Console.WriteLine("Enter different unit...");
                            break;
                    }
                    break;
            }
        }
    }
}
