using System.Text;

namespace csharp_programming {
    class Program {
        public static void Main() {
            try {
                FileStream booksFile = new FileStream("books.txt", FileMode.Open, FileAccess.ReadWrite);
                Book book = new Book() { Name = "Rich dad, poor dad", Price = 375 };
                string s = string.Format("{0, -20} {1, 10:F2}", book.Name, book.Price);
                UTF8Encoding e = new UTF8Encoding();
                byte[] bytes = e.GetBytes(s);
                int byteCount = e.GetByteCount("A") * 31;

                booksFile.Seek(byteCount, SeekOrigin.Begin);
                booksFile.Write(bytes, 0, bytes.Length);

                booksFile.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}