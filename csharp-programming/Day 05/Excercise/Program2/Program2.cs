namespace csharp_programming {
    internal class Program2 {
        TowerFactory IPF = new TowerFactory();
        IProperty ip = IPF.CreateProperty();
    }
}
