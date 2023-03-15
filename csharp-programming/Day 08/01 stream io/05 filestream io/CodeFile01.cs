using System.Text;

namespace csharp_programming {
    class Program {
        public static void Main() {
            try {
                Book[] books = new Book[] {
                new Book() {Name = "A file balance", Price = 125},
                new Book() {Name = "The Guide", Price = 158},
                new Book() {Name = "feasting, Feasting", Price = 258}
            };

                FileStream booksFile = new FileStream("books.txt", FileMode.Create, FileAccess.Write);
                UTF8Encoding e = new UTF8Encoding();

                foreach (Book book in books) {
                    string s = string.Format("{0, -20} {1, 10:F2}", book.Name, book.Price);
                    byte[] bytes = e.GetBytes(s);
                    booksFile.Write(bytes, 0, bytes.Length);
                }

                booksFile.Close();
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}