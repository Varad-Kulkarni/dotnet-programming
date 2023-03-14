namespace Csharp_programmin {
    class Integer {
        int value;

        public Integer(int value) {
            this.value = value;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Integer i1 = new Integer(1);
            Integer i2 = new Integer(1);

            bool result1 = i1.Equals(i2);
            bool result2 = Object.Equals(i1, i2);

            Console.WriteLine(result1 + " " + result2);
        }
    }
}

/*
 * The default implementation of Equals compares objects by address.
 * As a result, two distict objects having the same value when compared with Equals,
 * returns false.
 */