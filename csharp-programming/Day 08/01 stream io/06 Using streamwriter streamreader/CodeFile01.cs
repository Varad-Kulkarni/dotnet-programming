namespace csharp_programming {
    class Program {
        public static void Main() {
            try {
                StreamWriter sw = new StreamWriter("text.txt");
                sw.WriteLine("Hello World from stream writer...");
                sw.Close();
            }
            catch(IOException e) {
                Console.WriteLine("An io exception occured");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;
            }
        }
    }
}