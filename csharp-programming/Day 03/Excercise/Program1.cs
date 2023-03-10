using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_03.Excercise {

    class Book {
        private string title;
        private string author;
        private DateTime publicationDate;

        public string Title {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author {
            get { return this.author; }
            set { this.author = value; }
        }

        public DateTime PublicationDate {
            get { return this.publicationDate;}
            set { this.publicationDate = value; }
        }

        public int GetAge() {
            return 2023 - this.publicationDate.Year;
        }
    }

    internal class Program1 {
        public static void Main(string[] args) {
            Book book = new Book();
            book.Title = "ABC";
            book.Author = "XYX";
            book.PublicationDate = new DateTime(2011, 3, 4);
            Console.WriteLine(book.GetAge());
        }
    }
}
