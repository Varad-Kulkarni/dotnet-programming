using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.Excercise {
    internal class Program10 {
        static int FindNemo(string str) {
            string[] arr = str.Split(' ');

            for(int i=0; i<arr.Length; i++) {
                if (arr[i] == "Nemo") {
                    return i + 1;
                }
            }
            return -1;
        } 

        static void Main(string[] args) {
            Console.WriteLine("Enter number of testcases: ");
            int t = Convert.ToInt32(Console.ReadLine());

            while(t-- > 0) {
                Console.WriteLine("Enter the statement...");
                int index = FindNemo(Console.ReadLine());
                if(index == -1) {
                    Console.WriteLine("I can't find Nemo :("); 
                }
                else {
                    Console.WriteLine("I find Nemo at " + index);
                }
            }
        }
    }
}
