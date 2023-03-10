namespace csharp_programming {
    internal class Program3 {
        public static void Main(string[] args) {
            Resister r1 = new Resister(2.0);
            Resister r2 = new Resister(4.0);
            Resister r3 = new Resister(6.0);
            Resister r4 = new Resister(8.0);

            ResisterCollection pr = new ParallelResister();
            pr.Add(r3);
            pr.Add(r4);

            ResisterCollection sr = new SeriesResister();
            sr.Add(r1);
            sr.Add(r2);
            sr.Add(pr);

            Console.WriteLine(sr.GetResistance());
        }
    }
}
