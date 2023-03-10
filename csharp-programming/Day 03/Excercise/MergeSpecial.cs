//Q. Merge sorted arrays (Mutated problem)

//    input =>  [ 1, 5, 12, 19, 29, 33 ];
//              [ 3, 8, 15, 31 ];

//    output => [ 1, 3, 5, 8, 12, 15 ]
//              [ 19, 29, 31, 33 ]

namespace Exercise {
    class Program {
        public static int InsertAfter(int[] a, int index, int value) {
            int temp = a[a.Length - 1];
            for(int i=a.Length-1; i>index; i--) {
                a[i] = a[i - 1];
            }
            a[index] = value;
            return temp;
        }

        public static int InsertBefore(int[] a, int index, int value) {
            int temp = a[0];
            for(int i=0; i<index; i++) {
                a[i] = a[i + 1];
            }
            a[index] = value;
            return temp;
        }

        public static void Main(string[] args) {
            int[] a1 = new int[] { 1, 5, 12, 19, 29, 33 };
            int[] a2 = new int[] { 3, 8, 15, 31 };

            int i = 0, j = 0, k = a2.Length - 1; 
            while(i < a1.Length && j < a2.Length) {
                if (a1[i] > a2[j]) {
                    int temp1 = InsertAfter(a1, i, a2[j]);
                    while (k >= 0 && a2[k] > temp1) {
                        k--;
                    }
                    InsertBefore(a2, k, temp1);
                    i++;
                }
                else {
                    i++;
                }
            }

            foreach(int val in a1) {
                Console.Write(val + " ");
            }
            Console.WriteLine();
            foreach (int val in a2) {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}