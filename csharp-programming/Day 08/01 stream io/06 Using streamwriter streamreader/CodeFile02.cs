namespace csharp_programming {
    class Program {
        public static void Main() {
            try {
                StreamReader sr = new StreamReader("text.txt");

                int charData;
                charData = sr.Read();
                while(charData != -1) {
                    Console.Write(Convert.ToChar(charData));
                    charData = sr.Read();
                    Thread.Sleep(100);
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