namespace csharp_programming {
    internal class Resister : IResister {
        double val;

        public Resister(double val) {
            this.val = val;
        }
        public double GetResistance() {
            return this.val;
        }
    }
}
