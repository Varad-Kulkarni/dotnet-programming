namespace csharp_programming {
    class Program {
        public static void Main() {
            try {
                StreamReader sr = new StreamReader("text.txt");

                string line;
                line = sr.ReadLine();

                while(line != null) {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                
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