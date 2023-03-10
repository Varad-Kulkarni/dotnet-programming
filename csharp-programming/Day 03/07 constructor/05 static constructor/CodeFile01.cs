namespace csharp_programming {
    class Integer {
        public static int value;
        static Integer() {
            value = 1;
        }
    }
    class Program {
        static void Main() {
            Integer integer = new Integer();
            //integer.value;
            //Integer.value;
        }
    }
}

/*
 * - Static constructor is invoked only once when any member of the class is accessed.
 */
