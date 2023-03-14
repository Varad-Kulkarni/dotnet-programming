namespace Csharp_programmin {
    class Integer {
        int value;

        public Integer(int value) {
            this.value = value;
        }

        public override bool Equals(object obj) {
            if(obj == null || obj.GetType() != typeof(Integer)) {
                return false;
            }
            Integer other = (Integer)obj;
            return this.value == other.value;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Integer i1 = new Integer(1);
            Integer i2 = new Integer(1);

            Console.WriteLine(i1.Equals(i2));
            Console.WriteLine(Object.Equals(i1, i2));

            Console.WriteLine(Object.ReferenceEquals(i1, i2));
            Console.WriteLine(i1.GetHashCode() == i2.GetHashCode());
        }
    }
}

/*
 * GetHashCode is needed when overriding Object.Equals to ensure
 * that objects that are equal have the same hash code.
 */