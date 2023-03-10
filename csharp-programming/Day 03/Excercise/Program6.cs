namespace Excercise {
    class Class {
        static public int Sum(params int[] arr) {
            int sum = 0;
            for(int i=0; i<arr.Length; i++) {
                sum += arr[i];
            }
            return sum;
        }

        static public int Sum(int[] arr, int n) {
            int sum = 0;
            for(int i=0; i<n; i++) {
                sum += arr[i];
            }
            return sum;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Console.WriteLine(Class.Sum(new int[] { 1, 2, 3, 4, 5 }, 5));
            Console.WriteLine(Class.Sum(1, 2, 3, 4, 5, 6));
        }
    }
}