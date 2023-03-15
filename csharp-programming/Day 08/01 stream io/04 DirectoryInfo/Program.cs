namespace csharp_programming {
    internal class Program {
        public static void Main() {
            string filename = "b.txt";
            FileInfo f = new FileInfo(filename);

            string dir = "temp";
            DirectoryInfo d = new DirectoryInfo(dir);

            if(d.Exists) {
                d.Delete(true);
            }
            d.Create();
            f.MoveTo(d.ToString() + @"/" + f.ToString());
        }
    }
}
