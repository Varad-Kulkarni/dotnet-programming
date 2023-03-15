namespace csharp_programming {
    class Program {
        public static void Main() {
            try {
                StreamReader sr = new StreamReader("text.txt");

                string s;
                s = sr.ReadToEnd();
                Console.WriteLine(s);
                sr.Close();
            }
            catch (IOException e) {
                Console.WriteLine("An io exception occured");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;
            }
        }
    }
}