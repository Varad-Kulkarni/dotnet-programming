using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming {
    internal class Program1 {
        public static void Main(string[] args) {
            string str = "";
            bool flag = true;
            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();

            int start = 0, end = str.Length - 1;
            while (start <= end)
            {
                if (str[start] != str[end])
                {
                    flag = false;
                    break;
                }
                start++;
                end--;
            }
            if (flag) {
                Console.WriteLine("Given string is a palindrome");
            }
            else {
                Console.WriteLine("Given string is not a palindrome");
            }
        }
    }
}
