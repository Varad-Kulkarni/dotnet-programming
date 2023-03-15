using System.Globalization;

namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            string filename = "a.txt";

            if(File.Exists(filename)) {
                File.Delete(filename);
            }

            File.WriteAllText(filename, "Hello world");
            File.AppendAllText(filename, "\n");
            File.AppendAllText(filename, "Bye World");

            string file2 = "b.txt";
            if(File.Exists(file2)) {
                File.Delete(file2);
            }
            File.Copy(filename, file2);
        }
    }
}
