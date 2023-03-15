namespace csharp_programming {
    internal class Program {
        public static void Main() {
            string dir = "temp";

            if(Directory.Exists(dir)) {
                Directory.Delete(dir, true);
            }
            Directory.CreateDirectory(dir);
            File.Move("b.txt", dir + @"/");
        }
    }
}
