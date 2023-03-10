using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Excercise {
    internal class Program6 {
        public static void Main(string[] args) {
            Console.WriteLine("Enter first number...");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number...");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int product = num1 * num2;
            string s = product.ToString();
            int n = s.Length, max = 1, start = 0;

            for (int i = 0; i < s.Length; i++) {
                for (int j = i; j < s.Length; j++) {
                    int flag = 1;

                    for(int k=0; k<(j-i+1)/2; k++) {
                        if (s[i+k] != s[j-k]) {
                            flag = 0;
                        }
                    }

                    if(flag != 0 && j-i+1>max) {
                        start = i;
                        max = j - i + 1;
                    }
                }
            }

            Console.Write("Largest palindrome is ");
            int length = 0;
            for(int i=start; i<start+max; i++) {
                length++;
                Console.Write(s[i]);
            }
            Console.Write(" of length " + length);

        }
    }
}