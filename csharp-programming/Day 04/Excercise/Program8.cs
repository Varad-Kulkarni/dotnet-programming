namespace Excercise {
    class Vector {
        private int i;
        private int j;
        private int k;

        public Vector(int i, int j, int k) {
            this.i = i;
            this.j = j;
            this.k = k;
        }

        public int I { get; set; }
        public int J { get; set; }
        public int K { get; set; }

        public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.I + v2.I, v1.J + v2.J, v1.K + v2.K);
        public static Vector operator -(Vector v1, Vector v2) => new Vector(v1.I - v2.I, v1.J - v2.J, v1.K - v2.K);
        public static Vector operator *(Vector v1, Vector v2) => new Vector(v1.I * v2.I, v1.J * v2.J, v1.K * v2.K);
        public static Vector operator /(Vector v1, Vector v2) => new Vector(v1.I / v2.I, v1.J / v2.J, v1.K / v2.K);
    }

    class Program {
        public static void Main(string[] args) {
            //
        }
    }
}