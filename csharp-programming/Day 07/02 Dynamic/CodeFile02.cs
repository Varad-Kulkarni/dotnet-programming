namespace csharp_programming {
    class program {
        public static T Add<T>(T u, T v) {
            dynamic du = u;
            dynamic dv = v;
            return du + dv;
        }

        public static void Main() {
            int u1 = 3, u2 = 6, u3 = 0;
            u3 = Add(u1, u2);

            double v1 = 3.3, v2 = 6.6, v3 = 0;
            v3 = Add(v1, v2);
        }
    }
}