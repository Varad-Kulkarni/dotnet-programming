using System.Text;

namespace csharp_programming {
    class Program {
        public static void Main() {
            try { 
                FileStream booksFile = new FileStream("books.txt", FileMode.Open, FileAccess.Read);
                UTF8Encoding e = new UTF8Encoding();
                List<Book> ls = new List<Book>();
                int byteCount = e.GetByteCount("A") * 31;
                byte[] bytes = new byte[byteCount];

                do {
                    if (booksFile.Read(bytes, 0, byteCount) == 0) {
                        break;
                    }

                    string bookData = e.GetString(bytes);
                    ls.Add(new Book() {
                        Name = bookData.Substring(0, 20).Trim(),
                        Price = Convert.ToDouble(bookData.Substring(21))
                    });
                } while (true);

                booksFile.Close();

                booksFile.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}