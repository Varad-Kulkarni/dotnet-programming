namespace csharp_programming {
    internal abstract class ResisterCollection : IResister {
        private protected List<IResister> resistance;

        private protected virtual void Add(IResister resister) {
            resistance.Add(resister);
        }
        public abstract double GetResistance();
    }
}
