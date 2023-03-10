using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming {
    internal class Program2 {
        public static void Main(string[] args) {
            string input1 = "", input2 = "";
            Console.WriteLine("Enter the temperature: ");
            input1 = Console.ReadLine();
            Console.WriteLine("Enter the case number for unit: ");
            Console.WriteLine("1. Celcius");
            Console.WriteLine("2. Fehrenite");
            input2 = Console.ReadLine();
            double temperature = Convert.ToDouble(input1);
            int Case = Convert.ToInt32(input2);

            double finalTemp = 0.0;
            switch(Case) {
                case 1:
                    finalTemp = 1.8 * temperature + 32;
                    break;

                case 2:
                    finalTemp = ((temperature - 32) * 5) / 9;
                    break;

                default:
                    Console.WriteLine("Enter valid case number");
                    break;
            }

            switch(Case) {
                case 1:
                    Console.WriteLine("Final temperature is " + finalTemp + " Fehrenite");
                    break;

                case 2:
                    Console.WriteLine("Final temperature is " + finalTemp + " Celcius");
                    break;

                default:
                    Console.WriteLine("Enter valid operation");
                    break;
            }
        }
    }
}
