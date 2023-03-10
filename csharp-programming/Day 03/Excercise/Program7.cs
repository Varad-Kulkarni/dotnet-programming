namespace Excercise {
    class ArraySorter {
        public static int[] SortDescending(params int[][] arrays) {
            int totalElements = 0;
            foreach (int[] a in arrays) {
                totalElements += a.Length;
            }

            int[] ans = new int[totalElements];
            int i = 0;
            foreach (int[] a in arrays) {
                foreach(int element in a) {
                    ans[i++] = element;
                }
            }

            Array.Sort(ans);
            Array.Reverse(ans);
            return ans;
        } 
    }

    class Program {
        public static void Main(string[] args) {
            int[] result = ArraySorter.SortDescending(
                new int[] { 71, 30, 18, 76, 91 },
                new int[] { 17, 27, 77, 74, 15 },
                new int[] { 71, 51, 76 },
                new int[] { 78, 4, 94, 87 }
                );

            for(int i=0; i<result.Length; i++) {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}