using System.Globalization;

namespace csharp_programming {
    internal class Program {
        public static void Main() {
            string file = "a.txt";
            FileInfo f = new FileInfo(file);

            if(f.Exists) {
                f.Delete();
            }

            StreamWriter sw = f.AppendText();
            sw.Write("Hello");
            sw.Write("\n");
            sw.Write("Bye");
            sw.Close();

            string file2 = "b.txt";
            FileInfo f2 = new FileInfo(file2);

            if(f2.Exists) {
                f2.Delete();
            }
            f.CopyTo(file2);
        }
    }
}
