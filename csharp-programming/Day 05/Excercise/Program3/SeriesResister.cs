namespace csharp_programming {
    internal class SeriesResister : ResisterCollection {
        public SeriesResister() {
            resistance = new List<IResister>();
        } 
        
        public override double GetResistance() {
            double effectiveResistance = 0.0;

            foreach(IResister resister in resistance) {
                effectiveResistance+= resister.GetResistance();
            }

            return effectiveResistance;
        }
    }
}
