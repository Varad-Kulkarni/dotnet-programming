namespace Excercise {
    public static class ArrayExtension {
        public static T[] GetRange<T>(this T[] arr, int start, int length) {
            if(start < 0 || length > arr.Length || start > length) {
                throw new Exception("Invalid operation...");
            }
            T[] result = new T[length - start];
            int index = 0;
            for(int i = start; i < length; i++) {
                result[index++] = arr[i];
            }
            return result;
        }
    }

    class Program {
        public static void Main() {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] ans = arr.GetRange(2, 7);
            for (int i = 0; i < ans.Length; i++) {
                Console.Write(ans[i] + " ");
            }
            Console.WriteLine();

            double[] arr1 = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            double[] ans1 = arr1.GetRange(2, 7);
            for (int i = 0; i < ans1.Length; i++) {
                Console.Write(ans1[i] + " ");
            }
            Console.WriteLine();

        }
    }
}