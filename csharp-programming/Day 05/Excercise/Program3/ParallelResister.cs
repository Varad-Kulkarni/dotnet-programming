namespace csharp_programming {
    internal class ParallelResister : ResisterCollection {
        public ParallelResister() {
            resistance = new List<IResister>();
        }

        public override double GetResistance() {
            double effectiveResistance = 0.0;

            foreach (IResister resister in resistance) {
                effectiveResistance += 1.0 / resister.GetResistance();
            }

            return 1.0 / effectiveResistance;
        }
    }
}
