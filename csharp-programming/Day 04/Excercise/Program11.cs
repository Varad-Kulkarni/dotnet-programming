namespace Excercise {
    class ArrayExtension<T> {
        public static T[] GetRange(T[] arr, int start, int length) {
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
            int[] ans = ArrayExtension<int>.GetRange(arr, 2, 7);
            for(int i=0; i<ans.Length; i++) {
                Console.Write(ans[i] + " ");
            }
            Console.WriteLine();
        }
    }
}