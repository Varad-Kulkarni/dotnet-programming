using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming {
    internal class Program3 {
        public static void Main(string[] args) {
            Console.WriteLine("Enter depth for pascle triangle: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            for(int i=1; i<=n; i++) {
                int k = 1;
                for(int j=1; j<=i; j++) {
                    Console.Write(k + " ");
                    k = k * (i - j) / j;
                }
                Console.WriteLine();
            }
        }
    }
}
