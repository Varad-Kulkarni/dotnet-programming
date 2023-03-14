namespace Excercise {
    class Vector {
        public int I { get; set; }
        public int J { get; set; }
        public int K { get; set; }

        public Vector(int i, int j, int k) {
            this.I = i;
            this.J = j;
            this.K = k;
        }

        public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.I + v2.I, v1.J + v2.J, v1.K + v2.K);
        public static Vector operator -(Vector v1, Vector v2) => new Vector(v1.I - v2.I, v1.J - v2.J, v1.K - v2.K);
        public static Vector operator *(Vector v1, Vector v2) => new Vector(v1.I * v2.I, v1.J * v2.J, v1.K * v2.K);
        public static Vector operator /(Vector v1, Vector v2) => new Vector(v1.I / v2.I, v1.J / v2.J, v1.K / v2.K);
    }

    class Program {
        public static void Main(string[] args) {
            Vector v1 = new Vector(9, 7, 3);
            Vector v2 = new Vector(2, 4, 6);
            Vector v3 = null;

            v3 = v1 + v2;
            Console.WriteLine(v3.I + " " + v3.J + " " + v3.K);

            v3 = v1 - v2;
            Console.WriteLine(v3.I + " " + v3.J + " " + v3.K);

            v3 = v1 * v2;
            Console.WriteLine(v3.I + " " + v3.J + " " + v3.K);

            v3 = v1 / v2;
            Console.WriteLine(v3.I + " " + v3.J + " " + v3.K);
        }
    }
}